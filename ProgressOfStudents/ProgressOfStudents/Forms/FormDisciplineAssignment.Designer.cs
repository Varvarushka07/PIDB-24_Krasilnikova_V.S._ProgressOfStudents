namespace ProgressOfStudents.Forms
{
    partial class FormDisciplineAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAcademicYear = new TextBox();
            labelAcademicYear = new Label();
            labelSemester = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            comboBoxDiscipline = new ComboBox();
            labelDiscipline = new Label();
            labelTeacher = new Label();
            comboBoxTeacher = new ComboBox();
            comboBoxDepartment = new ComboBox();
            labelDepartment = new Label();
            numericUpDownSemester = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSemester).BeginInit();
            SuspendLayout();
            // 
            // textBoxAcademicYear
            // 
            textBoxAcademicYear.Location = new Point(239, 268);
            textBoxAcademicYear.Name = "textBoxAcademicYear";
            textBoxAcademicYear.Size = new Size(182, 31);
            textBoxAcademicYear.TabIndex = 19;
            // 
            // labelAcademicYear
            // 
            labelAcademicYear.AutoSize = true;
            labelAcademicYear.Location = new Point(34, 274);
            labelAcademicYear.Name = "labelAcademicYear";
            labelAcademicYear.Size = new Size(121, 25);
            labelAcademicYear.TabIndex = 18;
            labelAcademicYear.Text = "Учебный год:";
            // 
            // labelSemester
            // 
            labelSemester.AutoSize = true;
            labelSemester.Location = new Point(34, 215);
            labelSemester.Name = "labelSemester";
            labelSemester.Size = new Size(84, 25);
            labelSemester.TabIndex = 16;
            labelSemester.Text = "Семестр:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(271, 359);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(50, 359);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 38);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxDiscipline
            // 
            comboBoxDiscipline.FormattingEnabled = true;
            comboBoxDiscipline.Location = new Point(239, 89);
            comboBoxDiscipline.Name = "comboBoxDiscipline";
            comboBoxDiscipline.Size = new Size(182, 33);
            comboBoxDiscipline.TabIndex = 13;
            // 
            // labelDiscipline
            // 
            labelDiscipline.AutoSize = true;
            labelDiscipline.Location = new Point(34, 97);
            labelDiscipline.Name = "labelDiscipline";
            labelDiscipline.Size = new Size(115, 25);
            labelDiscipline.TabIndex = 11;
            labelDiscipline.Text = "Дисциплина:";
            // 
            // labelTeacher
            // 
            labelTeacher.AutoSize = true;
            labelTeacher.Location = new Point(34, 43);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Size = new Size(142, 25);
            labelTeacher.TabIndex = 10;
            labelTeacher.Text = "Преподаватель:";
            // 
            // comboBoxTeacher
            // 
            comboBoxTeacher.FormattingEnabled = true;
            comboBoxTeacher.Location = new Point(239, 35);
            comboBoxTeacher.Name = "comboBoxTeacher";
            comboBoxTeacher.Size = new Size(182, 33);
            comboBoxTeacher.TabIndex = 20;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(239, 144);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(182, 33);
            comboBoxDepartment.TabIndex = 22;
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(34, 152);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(86, 25);
            labelDepartment.TabIndex = 21;
            labelDepartment.Text = "Кафедра:";
            // 
            // numericUpDownSemester
            // 
            numericUpDownSemester.Location = new Point(239, 209);
            numericUpDownSemester.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownSemester.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSemester.Name = "numericUpDownSemester";
            numericUpDownSemester.Size = new Size(180, 31);
            numericUpDownSemester.TabIndex = 23;
            numericUpDownSemester.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormDisciplineAssignment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(numericUpDownSemester);
            Controls.Add(comboBoxDepartment);
            Controls.Add(labelDepartment);
            Controls.Add(comboBoxTeacher);
            Controls.Add(textBoxAcademicYear);
            Controls.Add(labelAcademicYear);
            Controls.Add(labelSemester);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxDiscipline);
            Controls.Add(labelDiscipline);
            Controls.Add(labelTeacher);
            Name = "FormDisciplineAssignment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ведение дисциплины";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSemester).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAcademicYear;
        private Label labelAcademicYear;
        private Label labelSemester;
        private Button buttonCancel;
        private Button buttonSave;
        private ComboBox comboBoxDiscipline;
        private Label labelDiscipline;
        private Label labelTeacher;
        private ComboBox comboBoxTeacher;
        private ComboBox comboBoxDepartment;
        private Label labelDepartment;
        private NumericUpDown numericUpDownSemester;
    }
}