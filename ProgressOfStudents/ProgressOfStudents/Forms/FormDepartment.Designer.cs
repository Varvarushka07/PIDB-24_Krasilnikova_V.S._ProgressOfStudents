namespace ProgressOfStudents.Forms
{
    partial class FormDepartment
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
            labelName = new Label();
            labelDeanOffice = new Label();
            textBoxName = new TextBox();
            comboBoxDeanOffice = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelHeadFullName = new Label();
            textBoxHeadFullName = new TextBox();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(67, 70);
            labelName.Name = "labelName";
            labelName.Size = new Size(94, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Название:";
            // 
            // labelDeanOffice
            // 
            labelDeanOffice.AutoSize = true;
            labelDeanOffice.Location = new Point(67, 124);
            labelDeanOffice.Name = "labelDeanOffice";
            labelDeanOffice.Size = new Size(81, 25);
            labelDeanOffice.TabIndex = 1;
            labelDeanOffice.Text = "Деканат:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(272, 64);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(182, 31);
            textBoxName.TabIndex = 2;
            // 
            // comboBoxDeanOffice
            // 
            comboBoxDeanOffice.FormattingEnabled = true;
            comboBoxDeanOffice.Location = new Point(272, 116);
            comboBoxDeanOffice.Name = "comboBoxDeanOffice";
            comboBoxDeanOffice.Size = new Size(182, 33);
            comboBoxDeanOffice.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(86, 347);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 38);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(307, 347);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelHeadFullName
            // 
            labelHeadFullName.AutoSize = true;
            labelHeadFullName.Location = new Point(67, 184);
            labelHeadFullName.Name = "labelHeadFullName";
            labelHeadFullName.Size = new Size(175, 25);
            labelHeadFullName.TabIndex = 6;
            labelHeadFullName.Text = "ФИО Заведующего:";
            // 
            // textBoxHeadFullName
            // 
            textBoxHeadFullName.Location = new Point(272, 178);
            textBoxHeadFullName.Name = "textBoxHeadFullName";
            textBoxHeadFullName.Size = new Size(182, 31);
            textBoxHeadFullName.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(272, 237);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(182, 31);
            textBoxPhone.TabIndex = 9;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(67, 243);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(85, 25);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "Телефон:";
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 418);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxHeadFullName);
            Controls.Add(labelHeadFullName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxDeanOffice);
            Controls.Add(textBoxName);
            Controls.Add(labelDeanOffice);
            Controls.Add(labelName);
            Name = "FormDepartment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Кафедра";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelDeanOffice;
        private TextBox textBoxName;
        private ComboBox comboBoxDeanOffice;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelHeadFullName;
        private TextBox textBoxHeadFullName;
        private TextBox textBoxPhone;
        private Label labelPhone;
    }
}