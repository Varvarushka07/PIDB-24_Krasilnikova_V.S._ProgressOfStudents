namespace ProgressOfStudents.Forms
{
    partial class FormDiscipline
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
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxName = new TextBox();
            labelHours = new Label();
            labelName = new Label();
            numericUpDownHours = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(289, 217);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(68, 217);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 38);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(259, 56);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(182, 31);
            textBoxName.TabIndex = 12;
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Location = new Point(54, 116);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(58, 25);
            labelHours.TabIndex = 11;
            labelHours.Text = "Часы:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(54, 62);
            labelName.Name = "labelName";
            labelName.Size = new Size(94, 25);
            labelName.TabIndex = 10;
            labelName.Text = "Название:";
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Location = new Point(259, 110);
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(180, 31);
            numericUpDownHours.TabIndex = 20;
            // 
            // FormDiscipline
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 316);
            Controls.Add(numericUpDownHours);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Controls.Add(labelHours);
            Controls.Add(labelName);
            Name = "FormDiscipline";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Дисциплина";
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxName;
        private Label labelHours;
        private Label labelName;
        private NumericUpDown numericUpDownHours;
    }
}