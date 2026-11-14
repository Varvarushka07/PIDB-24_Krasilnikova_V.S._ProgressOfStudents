using System;
using System.Windows.Forms;
using ProgressOfStudents.Entities;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormDisciplineAssignment : Form
    {
        private readonly IDisciplineAssignmentRepository _assignmentRepository;

        public FormDisciplineAssignment(
            IDisciplineAssignmentRepository assignmentRepository,
            ITeacherRepository teacherRepository,
            IDisciplineRepository disciplineRepository,
            IDepartmentRepository departmentRepository)
        {
            InitializeComponent();
            _assignmentRepository = assignmentRepository ?? throw new ArgumentNullException(nameof(assignmentRepository));

            comboBoxTeacher.DataSource = teacherRepository.ReadTeachers();
            comboBoxTeacher.DisplayMember = "FullName";
            comboBoxTeacher.ValueMember = "Id";

            comboBoxDiscipline.DataSource = disciplineRepository.ReadDisciplines();
            comboBoxDiscipline.DisplayMember = "Name";
            comboBoxDiscipline.ValueMember = "Id";

            comboBoxDepartment.DataSource = departmentRepository.ReadDepartments();
            comboBoxDepartment.DisplayMember = "Name";
            comboBoxDepartment.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTeacher.SelectedValue == null ||
                    comboBoxDiscipline.SelectedValue == null ||
                    comboBoxDepartment.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(textBoxAcademicYear.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                int teacherId = Convert.ToInt32(comboBoxTeacher.SelectedValue);
                int disciplineId = Convert.ToInt32(comboBoxDiscipline.SelectedValue);
                int departmentId = Convert.ToInt32(comboBoxDepartment.SelectedValue);

                _assignmentRepository.CreateAssignment(CreateAssignment(0, teacherId, disciplineId, departmentId));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private DisciplineAssignment CreateAssignment(int id, int teacherId, int disciplineId, int departmentId) =>
            DisciplineAssignment.CreateEntity(
                id,
                teacherId,
                disciplineId,
                departmentId,
                (int)numericUpDownSemester.Value,
                textBoxAcademicYear.Text);
    }
}