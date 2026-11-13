using System;
using System.Windows.Forms;
using Unity;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormGroups : Form
    {
        private readonly IUnityContainer _container;
        private readonly IGroupRepository _groupRepository;

        public FormGroups(IUnityContainer container, IGroupRepository groupRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _groupRepository = groupRepository ?? throw new ArgumentNullException(nameof(groupRepository));
        }

        private void FormGroups_Load(object sender, EventArgs e)
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
                _container.Resolve<FormGroup>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList()
        {
            dataGridViewGroups.DataSource = _groupRepository.ReadGroups();
        }
    }
}