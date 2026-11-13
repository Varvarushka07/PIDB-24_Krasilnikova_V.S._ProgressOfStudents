using System;
using System.Windows.Forms;
using Unity;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormAcademicPerformances : Form
    {
        private readonly IUnityContainer _container;
        private readonly IAcademicPerformanceRepository _performanceRepository;

        public FormAcademicPerformances(IUnityContainer container, IAcademicPerformanceRepository performanceRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _performanceRepository = performanceRepository ?? throw new ArgumentNullException(nameof(performanceRepository));
        }

        private void FormAcademicPerformances_Load(object sender, EventArgs e)
        {
            try
            {
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormAcademicPerformance>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList()
        {
            dataGridViewPerformances.DataSource = _performanceRepository.ReadPerformances();
        }
    }
}