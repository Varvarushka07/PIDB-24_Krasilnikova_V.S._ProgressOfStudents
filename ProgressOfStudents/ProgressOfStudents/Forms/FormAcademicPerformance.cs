using System;
using System.Windows.Forms;
using ProgressOfStudents.Entities;
using ProgressOfStudents.Entities.Enums;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormAcademicPerformance : Form
    {
        private readonly IAcademicPerformanceRepository _performanceRepository;

        public FormAcademicPerformance(
            IAcademicPerformanceRepository performanceRepository,
            IStudentRepository studentRepository,
            IDisciplineAssignmentRepository assignmentRepository)
        {
            InitializeComponent();
            _performanceRepository = performanceRepository ?? throw new ArgumentNullException(nameof(performanceRepository));

            comboBoxStudent.DataSource = studentRepository.ReadStudents();
            comboBoxStudent.DisplayMember = "FullName";
            comboBoxStudent.ValueMember = "Id";

            comboBoxAssignment.DataSource = assignmentRepository.ReadAssignments();
            comboBoxAssignment.DisplayMember = "Id"; 
            comboBoxAssignment.ValueMember = "Id";

            comboBoxControlType.DataSource = Enum.GetValues(typeof(ControlType));
            comboBoxControlType.SelectedIndex = 1; 

            dateTimePickerExamDate.Value = DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxStudent.SelectedValue == null ||
                    comboBoxAssignment.SelectedValue == null ||
                    comboBoxControlType.SelectedItem == null)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                int studentId = Convert.ToInt32(comboBoxStudent.SelectedValue);
                int assignmentId = Convert.ToInt32(comboBoxAssignment.SelectedValue);
                ControlType controlType = (ControlType)comboBoxControlType.SelectedItem;

                _performanceRepository.CreatePerformance(CreatePerformance(0, studentId, assignmentId, controlType));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private AcademicPerformance CreatePerformance(int id, int studentId, int assignmentId, ControlType controlType)
        {
            return AcademicPerformance.CreateOperation(
                studentId,
                assignmentId,
                (int)numericUpDownGrade.Value,
                controlType);
        }
    }
}