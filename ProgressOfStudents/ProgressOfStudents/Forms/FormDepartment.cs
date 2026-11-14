using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ProgressOfStudents.Entities;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormDepartment : Form
    {
        private readonly IDepartmentRepository _departmentRepository;
        private int? _departmentId;

        [Browsable(false)]
        public int Id
        {
            set
            {
                try
                {
                    var department = _departmentRepository.ReadDepartmentById(value);
                    if (department == null)
                    {
                        throw new InvalidDataException(nameof(department));
                    }

                    textBoxName.Text = department.Name;
                    textBoxHeadFullName.Text = department.HeadFullName;
                    textBoxPhone.Text = department.Phone;
                    comboBoxDeanOffice.SelectedValue = department.DeanOfficeId;

                    _departmentId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormDepartment(IDepartmentRepository departmentRepository, IDeanOfficeRepository deanOfficeRepository)
        {
            InitializeComponent();
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));

            comboBoxDeanOffice.DataSource = deanOfficeRepository.ReadDeanOffices();
            comboBoxDeanOffice.DisplayMember = "Name"; 
            comboBoxDeanOffice.ValueMember = "Id";     
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) || comboBoxDeanOffice.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_departmentId.HasValue)
                {
                    _departmentRepository.UpdateDepartment(CreateDepartment(_departmentId.Value));
                }
                else
                {
                    _departmentRepository.CreateDepartment(CreateDepartment(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private Department CreateDepartment(int id) =>
            Department.CreateEntity(id, textBoxName.Text, (int)comboBoxDeanOffice.SelectedValue!, textBoxHeadFullName.Text, textBoxPhone.Text);
    }
}