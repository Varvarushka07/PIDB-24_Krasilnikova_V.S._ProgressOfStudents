using ProgressOfStudents.Entities;
using ProgressOfStudents.Repositories;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ProgressOfStudents.Forms
{
    public partial class FormDeanOffice : Form
    {
        private readonly IDeanOfficeRepository _deanOfficeRepository;
        private int? _deanOfficeId;
        public int Id
        {
            set
            {
                try
                {
                    var deanOffice = _deanOfficeRepository.ReadDeanOfficeById(value);
                    if (deanOffice == null)
                    {
                        throw new InvalidDataException(nameof(deanOffice));
                    }

                    textBoxName.Text = deanOffice.Name;
                    textBoxDeanFullName.Text = deanOffice.DeanFullName;
                    textBoxPhone.Text = deanOffice.Phone;

                    _deanOfficeId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormDeanOffice(IDeanOfficeRepository deanOfficeRepository)
        {
            InitializeComponent();
            _deanOfficeRepository = deanOfficeRepository ?? throw new ArgumentNullException(nameof(deanOfficeRepository));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxDeanFullName.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_deanOfficeId.HasValue)
                {
                    _deanOfficeRepository.UpdateDeanOffice(CreateDeanOffice(_deanOfficeId.Value));
                }
                else
                {
                    _deanOfficeRepository.CreateDeanOffice(CreateDeanOffice(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private DeanOffice CreateDeanOffice(int id) =>
            DeanOffice.CreateEntity(id, textBoxName.Text, textBoxDeanFullName.Text, textBoxPhone.Text);
    }
}