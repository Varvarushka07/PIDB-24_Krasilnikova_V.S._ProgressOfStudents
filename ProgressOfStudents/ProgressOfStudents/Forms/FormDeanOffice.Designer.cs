namespace ProgressOfStudents.Forms
{
    partial class FormDeanOffice
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
            labelDeanFullName = new Label();
            labelPhone = new Label();
            textBoxName = new TextBox();
            textBoxDeanFullName = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxPhone = new TextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(34, 73);
            labelName.Name = "labelName";
            labelName.Size = new Size(94, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Название:";
            // 
            // labelDeanFullName
            // 
            labelDeanFullName.AutoSize = true;
            labelDeanFullName.Location = new Point(34, 138);
            labelDeanFullName.Name = "labelDeanFullName";
            labelDeanFullName.Size = new Size(119, 25);
            labelDeanFullName.TabIndex = 1;
            labelDeanFullName.Text = "ФИО Декана:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(34, 202);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(85, 25);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Телефон:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(213, 67);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 3;
            // 
            // textBoxDeanFullName
            // 
            textBoxDeanFullName.Location = new Point(209, 135);
            textBoxDeanFullName.Name = "textBoxDeanFullName";
            textBoxDeanFullName.Size = new Size(150, 31);
            textBoxDeanFullName.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(63, 289);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(271, 289);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(209, 196);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(150, 31);
            textBoxPhone.TabIndex = 7;
            // 
            // FormDeanOffices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 369);
            Controls.Add(textBoxPhone);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDeanFullName);
            Controls.Add(textBoxName);
            Controls.Add(labelPhone);
            Controls.Add(labelDeanFullName);
            Controls.Add(labelName);
            Name = "FormDeanOffices";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Деканат";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelDeanFullName;
        private Label labelPhone;
        private TextBox textBoxName;
        private TextBox textBoxDeanFullName;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxPhone;
    }
}