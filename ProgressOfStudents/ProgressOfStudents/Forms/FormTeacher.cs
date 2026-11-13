using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ProgressOfStudents.Entities;
using ProgressOfStudents.Repositories;

namespace ProgressOfStudents.Forms
{
    public partial class FormTeacher : Form
    {
        private readonly ITeacherRepository _teacherRepository;
        private int? _teacherId;

        [Browsable(false)]
        public int Id
        {
            set
            {
                try
                {
                    var teacher = _teacherRepository.ReadTeacherById(value);
                    if (teacher == null)
                    {
                        throw new InvalidDataException(nameof(teacher));
                    }

                    textBoxFullName.Text = teacher.FullName;

                    _teacherId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormTeacher(ITeacherRepository teacherRepository)
        {
            InitializeComponent();
            _teacherRepository = teacherRepository ?? throw new ArgumentNullException(nameof(teacherRepository));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_teacherId.HasValue)
                {
                    _teacherRepository.UpdateTeacher(CreateTeacher(_teacherId.Value));
                }
                else
                {
                    _teacherRepository.CreateTeacher(CreateTeacher(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private Teacher CreateTeacher(int id) =>
            Teacher.CreateEntity(id, textBoxFullName.Text);
    }
}