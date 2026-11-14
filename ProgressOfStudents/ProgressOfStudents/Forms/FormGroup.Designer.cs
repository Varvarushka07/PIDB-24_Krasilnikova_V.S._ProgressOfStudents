namespace ProgressOfStudents.Forms
{
    partial class FormGroup
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
            comboBoxStream = new ComboBox();
            numericUpDownCourse = new NumericUpDown();
            labelStream = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxGroupNumber = new TextBox();
            labelCourse = new Label();
            labelGroupNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCourse).BeginInit();
            SuspendLayout();
            // 
            // comboBoxStream
            // 
            comboBoxStream.FormattingEnabled = true;
            comboBoxStream.Location = new Point(250, 158);
            comboBoxStream.Name = "comboBoxStream";
            comboBoxStream.Size = new Size(182, 33);
            comboBoxStream.TabIndex = 39;
            // 
            // numericUpDownCourse
            // 
            numericUpDownCourse.Location = new Point(252, 100);
            numericUpDownCourse.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDownCourse.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCourse.Name = "numericUpDownCourse";
            numericUpDownCourse.Size = new Size(180, 31);
            numericUpDownCourse.TabIndex = 38;
            numericUpDownCourse.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelStream
            // 
            labelStream.AutoSize = true;
            labelStream.Location = new Point(47, 166);
            labelStream.Name = "labelStream";
            labelStream.Size = new Size(67, 25);
            labelStream.TabIndex = 37;
            labelStream.Text = "Поток:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(283, 272);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 36;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(69, 272);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 38);
            buttonSave.TabIndex = 35;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxGroupNumber
            // 
            textBoxGroupNumber.Location = new Point(252, 46);
            textBoxGroupNumber.Name = "textBoxGroupNumber";
            textBoxGroupNumber.Size = new Size(182, 31);
            textBoxGroupNumber.TabIndex = 34;
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Location = new Point(47, 106);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(54, 25);
            labelCourse.TabIndex = 33;
            labelCourse.Text = "Курс:";
            // 
            // labelGroupNumber
            // 
            labelGroupNumber.AutoSize = true;
            labelGroupNumber.Location = new Point(47, 52);
            labelGroupNumber.Name = "labelGroupNumber";
            labelGroupNumber.Size = new Size(138, 25);
            labelGroupNumber.TabIndex = 32;
            labelGroupNumber.Text = "Номер группы:";
            // 
            // FormGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxStream);
            Controls.Add(numericUpDownCourse);
            Controls.Add(labelStream);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxGroupNumber);
            Controls.Add(labelCourse);
            Controls.Add(labelGroupNumber);
            Name = "FormGroup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Группа";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxStream;
        private NumericUpDown numericUpDownCourse;
        private Label labelStream;
        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxGroupNumber;
        private Label labelCourse;
        private Label labelGroupNumber;
    }
}