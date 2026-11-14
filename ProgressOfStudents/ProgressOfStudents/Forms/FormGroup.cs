using System;
using System.Windows.Forms;
using ProgressOfStudents.Entities;
using ProgressOfStudents.Repositories;
using GroupEntity = ProgressOfStudents.Entities.Group; 

namespace ProgressOfStudents.Forms
{
    public partial class FormGroup : Form
    {
        private readonly IGroupRepository _groupRepository;

        public FormGroup(IGroupRepository groupRepository, IStreamRepository streamRepository)
        {
            InitializeComponent();
            _groupRepository = groupRepository ?? throw new ArgumentNullException(nameof(groupRepository));

            comboBoxStream.DataSource = streamRepository.ReadStreams();
            comboBoxStream.DisplayMember = "Name";
            comboBoxStream.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxGroupNumber.Text) || comboBoxStream.SelectedValue == null)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                int streamId = Convert.ToInt32(comboBoxStream.SelectedValue);
                _groupRepository.CreateGroup(CreateGroup(0, streamId));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private GroupEntity CreateGroup(int id, int streamId) =>
            GroupEntity.CreateEntity(id, textBoxGroupNumber.Text, (int)numericUpDownCourse.Value, streamId);
    }
}