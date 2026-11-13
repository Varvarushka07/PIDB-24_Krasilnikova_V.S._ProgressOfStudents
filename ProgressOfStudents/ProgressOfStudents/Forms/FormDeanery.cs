using System;
using System.Windows.Forms;
using Unity;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents
{
    public partial class FormDeanery : Form
    {
        private readonly IUnityContainer _container;

        public FormDeanery(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void DeanOfficesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormDeanOffices>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormDepartments>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisciplinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormDisciplines>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormTeachers>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormStreams>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormGroups>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormStudents>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AssignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormDisciplineAssignments>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PerformancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ProgressOfStudents.Forms.FormAcademicPerformances>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}