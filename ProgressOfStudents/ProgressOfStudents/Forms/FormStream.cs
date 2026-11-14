using System;
using System.Windows.Forms;
using ProgressOfStudents.Entities;
using ProgressOfStudents.Repositories;
using StreamEntity = ProgressOfStudents.Entities.Stream; 

namespace ProgressOfStudents.Forms
{
    public partial class FormStream : Form
    {
        private readonly IStreamRepository _streamRepository;

        public FormStream(IStreamRepository streamRepository, IDepartmentRepository departmentRepository)
        {
            InitializeComponent();
            _streamRepository = streamRepository ?? throw new ArgumentNullException(nameof(streamRepository));

            comboBoxDepartment.DataSource = departmentRepository.ReadDepartments();
            comboBoxDepartment.DisplayMember = "Name";
            comboBoxDepartment.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) || comboBoxDepartment.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                _streamRepository.CreateStream(CreateStream(0));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private StreamEntity CreateStream(int id) =>
            StreamEntity.CreateEntity(id, textBoxName.Text, (int)numericUpDownEnrollmentYear.Value, (int)comboBoxDepartment.SelectedValue!);
    }
}