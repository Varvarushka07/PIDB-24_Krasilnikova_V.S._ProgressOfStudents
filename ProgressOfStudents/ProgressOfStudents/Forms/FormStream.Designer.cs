namespace ProgressOfStudents.Forms
{
    partial class FormStream
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
            numericUpDownEnrollmentYear = new NumericUpDown();
            labelDepartment = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxName = new TextBox();
            labelEnrollmentYear = new Label();
            labelName = new Label();
            comboBoxDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnrollmentYear).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownEnrollmentYear
            // 
            numericUpDownEnrollmentYear.Location = new Point(246, 95);
            numericUpDownEnrollmentYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDownEnrollmentYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numericUpDownEnrollmentYear.Name = "numericUpDownEnrollmentYear";
            numericUpDownEnrollmentYear.Size = new Size(180, 31);
            numericUpDownEnrollmentYear.TabIndex = 30;
            numericUpDownEnrollmentYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(41, 161);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(86, 25);
            labelDepartment.TabIndex = 26;
            labelDepartment.Text = "Кафедра:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(277, 267);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(63, 267);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 38);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(246, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(182, 31);
            textBoxName.TabIndex = 23;
            // 
            // labelEnrollmentYear
            // 
            labelEnrollmentYear.AutoSize = true;
            labelEnrollmentYear.Location = new Point(41, 101);
            labelEnrollmentYear.Name = "labelEnrollmentYear";
            labelEnrollmentYear.Size = new Size(110, 25);
            labelEnrollmentYear.TabIndex = 22;
            labelEnrollmentYear.Text = "Год набора:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(41, 47);
            labelName.Name = "labelName";
            labelName.Size = new Size(94, 25);
            labelName.TabIndex = 21;
            labelName.Text = "Название:";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(244, 153);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(182, 33);
            comboBoxDepartment.TabIndex = 31;
            // 
            // FormStream
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 386);
            Controls.Add(comboBoxDepartment);
            Controls.Add(numericUpDownEnrollmentYear);
            Controls.Add(labelDepartment);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Controls.Add(labelEnrollmentYear);
            Controls.Add(labelName);
            Name = "FormStream";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поток";
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnrollmentYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownEnrollmentYear;
        private Label labelDepartment;
        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxName;
        private Label labelEnrollmentYear;
        private Label labelName;
        private ComboBox comboBoxDepartment;
    }
}