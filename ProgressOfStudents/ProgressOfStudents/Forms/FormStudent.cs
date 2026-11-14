using System;
using System.Windows.Forms;
using ProgressOfStudents.Entities;
using ProgressOfStudents.Entities.Enums;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormStudent : Form
    {
        private readonly IStudentRepository _studentRepository;

        public FormStudent(IStudentRepository studentRepository, IGroupRepository groupRepository)
        {
            InitializeComponent();
            _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));
            comboBoxGroup.DataSource = groupRepository.ReadGroups();
            comboBoxGroup.DisplayMember = "GroupNumber";
            comboBoxGroup.ValueMember = "Id";

            foreach (var status in Enum.GetValues(typeof(StudentStatus)))
            {
                if ((StudentStatus)status == StudentStatus.None) continue; 
                checkedListBoxStatus.Items.Add(status);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxRecordBookNumber.Text) ||
                    comboBoxGroup.SelectedValue == null ||
                    checkedListBoxStatus.CheckedItems.Count == 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                int groupId = Convert.ToInt32(comboBoxGroup.SelectedValue);
                _studentRepository.CreateStudent(CreateStudent(0, groupId));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private Student CreateStudent(int id, int groupId)
        {
            StudentStatus status = StudentStatus.None;
            foreach (var item in checkedListBoxStatus.CheckedItems)
            {
                status |= (StudentStatus)item;
            }

            return Student.CreateEntity(id, textBoxFullName.Text, textBoxRecordBookNumber.Text, groupId, status);
        }
    }
}