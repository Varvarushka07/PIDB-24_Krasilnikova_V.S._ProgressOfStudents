namespace ProgressOfStudents.Forms
{
    partial class FormTeacher
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
            textBoxFullName = new TextBox();
            labelFullName = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(254, 79);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(182, 31);
            textBoxFullName.TabIndex = 23;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(49, 85);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(56, 25);
            labelFullName.TabIndex = 22;
            labelFullName.Text = "ФИО:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(289, 248);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(68, 248);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 38);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormTeacher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 374);
            Controls.Add(textBoxFullName);
            Controls.Add(labelFullName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Name = "FormTeacher";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Преподаватель";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFullName;
        private Label labelFullName;
        private Button buttonCancel;
        private Button buttonSave;
    }
}