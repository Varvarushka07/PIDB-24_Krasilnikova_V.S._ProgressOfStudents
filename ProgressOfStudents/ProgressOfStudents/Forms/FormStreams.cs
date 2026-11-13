using System;
using System.Windows.Forms;
using Unity;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormStreams : Form
    {
        private readonly IUnityContainer _container;
        private readonly IStreamRepository _streamRepository;

        public FormStreams(IUnityContainer container, IStreamRepository streamRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _streamRepository = streamRepository ?? throw new ArgumentNullException(nameof(streamRepository));
        }

        private void FormStreams_Load(object sender, EventArgs e)
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
                _container.Resolve<FormStream>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList()
        {
            dataGridViewStreams.DataSource = _streamRepository.ReadStreams();
        }
    }
}