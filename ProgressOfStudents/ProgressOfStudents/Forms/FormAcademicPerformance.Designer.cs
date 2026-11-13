namespace ProgressOfStudents.Forms
{
    partial class FormAcademicPerformance
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
            numericUpDownGrade = new NumericUpDown();
            comboBoxControlType = new ComboBox();
            labelControlType = new Label();
            comboBoxStudent = new ComboBox();
            labelExamDate = new Label();
            labelGrade = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            comboBoxAssignment = new ComboBox();
            labelAssignment = new Label();
            labelStudent = new Label();
            dateTimePickerExamDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Location = new Point(246, 151);
            numericUpDownGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(180, 31);
            numericUpDownGrade.TabIndex = 35;
            numericUpDownGrade.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // comboBoxControlType
            // 
            comboBoxControlType.FormattingEnabled = true;
            comboBoxControlType.Location = new Point(244, 211);
            comboBoxControlType.Name = "comboBoxControlType";
            comboBoxControlType.Size = new Size(182, 33);
            comboBoxControlType.TabIndex = 34;
            // 
            // labelControlType
            // 
            labelControlType.AutoSize = true;
            labelControlType.Location = new Point(41, 219);
            labelControlType.Name = "labelControlType";
            labelControlType.Size = new Size(128, 25);
            labelControlType.TabIndex = 33;
            labelControlType.Text = "Вид контроля:";
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(244, 36);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(182, 33);
            comboBoxStudent.TabIndex = 32;
            // 
            // labelExamDate
            // 
            labelExamDate.AutoSize = true;
            labelExamDate.Location = new Point(41, 275);
            labelExamDate.Name = "labelExamDate";
            labelExamDate.Size = new Size(53, 25);
            labelExamDate.TabIndex = 30;
            labelExamDate.Text = "Дата:";
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Location = new Point(41, 157);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(78, 25);
            labelGrade.TabIndex = 29;
            labelGrade.Text = "Оценка:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(276, 360);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 28;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(55, 360);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 38);
            buttonSave.TabIndex = 27;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxAssignment
            // 
            comboBoxAssignment.FormattingEnabled = true;
            comboBoxAssignment.Location = new Point(244, 90);
            comboBoxAssignment.Name = "comboBoxAssignment";
            comboBoxAssignment.Size = new Size(182, 33);
            comboBoxAssignment.TabIndex = 26;
            // 
            // labelAssignment
            // 
            labelAssignment.AutoSize = true;
            labelAssignment.Location = new Point(39, 98);
            labelAssignment.Name = "labelAssignment";
            labelAssignment.Size = new Size(189, 25);
            labelAssignment.TabIndex = 25;
            labelAssignment.Text = "Ведение дисциплины:";
            // 
            // labelStudent
            // 
            labelStudent.AutoSize = true;
            labelStudent.Location = new Point(41, 44);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(79, 25);
            labelStudent.TabIndex = 24;
            labelStudent.Text = "Студент:";
            // 
            // dateTimePickerExamDate
            // 
            dateTimePickerExamDate.Location = new Point(244, 269);
            dateTimePickerExamDate.Name = "dateTimePickerExamDate";
            dateTimePickerExamDate.Size = new Size(228, 31);
            dateTimePickerExamDate.TabIndex = 36;
            // 
            // FormAcademicPerformance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerExamDate);
            Controls.Add(numericUpDownGrade);
            Controls.Add(comboBoxControlType);
            Controls.Add(labelControlType);
            Controls.Add(comboBoxStudent);
            Controls.Add(labelExamDate);
            Controls.Add(labelGrade);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxAssignment);
            Controls.Add(labelAssignment);
            Controls.Add(labelStudent);
            Name = "FormAcademicPerformance";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Успеваемость";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownGrade;
        private ComboBox comboBoxControlType;
        private Label labelControlType;
        private ComboBox comboBoxStudent;
        private Label labelExamDate;
        private Label labelGrade;
        private Button buttonCancel;
        private Button buttonSave;
        private ComboBox comboBoxAssignment;
        private Label labelAssignment;
        private Label labelStudent;
        private DateTimePicker dateTimePickerExamDate;
    }
}