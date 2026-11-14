using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ProgressOfStudents.Entities;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormDiscipline : Form
    {
        private readonly IDisciplineRepository _disciplineRepository;
        private int? _disciplineId;

        [Browsable(false)]
        public int Id
        {
            set
            {
                try
                {
                    var discipline = _disciplineRepository.ReadDisciplineById(value);
                    if (discipline == null)
                    {
                        throw new InvalidDataException(nameof(discipline));
                    }

                    textBoxName.Text = discipline.Name;
                    numericUpDownHours.Value = discipline.Hours;

                    _disciplineId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormDiscipline(IDisciplineRepository disciplineRepository)
        {
            InitializeComponent();
            _disciplineRepository = disciplineRepository ?? throw new ArgumentNullException(nameof(disciplineRepository));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_disciplineId.HasValue)
                {
                    _disciplineRepository.UpdateDiscipline(CreateDiscipline(_disciplineId.Value));
                }
                else
                {
                    _disciplineRepository.CreateDiscipline(CreateDiscipline(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private Discipline CreateDiscipline(int id) =>
            Discipline.CreateEntity(id, textBoxName.Text, (int)numericUpDownHours.Value);
    }
}