namespace ProgressOfStudents.Forms
{
    partial class FormStudent
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
            labelGroup = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxFullName = new TextBox();
            labelRecordBookNumber = new Label();
            labelFullName = new Label();
            labelStatus = new Label();
            comboBoxGroup = new ComboBox();
            textBoxRecordBookNumber = new TextBox();
            checkedListBoxStatus = new CheckedListBox();
            SuspendLayout();
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(38, 171);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(73, 25);
            labelGroup.TabIndex = 37;
            labelGroup.Text = "Группа:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(274, 366);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 36;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(64, 366);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 38);
            buttonSave.TabIndex = 35;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(243, 51);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(233, 31);
            textBoxFullName.TabIndex = 34;
            // 
            // labelRecordBookNumber
            // 
            labelRecordBookNumber.AutoSize = true;
            labelRecordBookNumber.Location = new Point(38, 111);
            labelRecordBookNumber.Name = "labelRecordBookNumber";
            labelRecordBookNumber.Size = new Size(103, 25);
            labelRecordBookNumber.TabIndex = 33;
            labelRecordBookNumber.Text = "№ зачётки:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(38, 57);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(56, 25);
            labelFullName.TabIndex = 32;
            labelFullName.Text = "ФИО:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(38, 219);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(67, 25);
            labelStatus.TabIndex = 40;
            labelStatus.Text = "Статус:";
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new Point(241, 163);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new Size(235, 33);
            comboBoxGroup.TabIndex = 39;
            // 
            // textBoxRecordBookNumber
            // 
            textBoxRecordBookNumber.Location = new Point(241, 105);
            textBoxRecordBookNumber.Name = "textBoxRecordBookNumber";
            textBoxRecordBookNumber.Size = new Size(235, 31);
            textBoxRecordBookNumber.TabIndex = 41;
            // 
            // checkedListBoxStatus
            // 
            checkedListBoxStatus.FormattingEnabled = true;
            checkedListBoxStatus.Location = new Point(241, 216);
            checkedListBoxStatus.Name = "checkedListBoxStatus";
            checkedListBoxStatus.Size = new Size(235, 116);
            checkedListBoxStatus.TabIndex = 42;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
            Controls.Add(checkedListBoxStatus);
            Controls.Add(textBoxRecordBookNumber);
            Controls.Add(labelStatus);
            Controls.Add(comboBoxGroup);
            Controls.Add(labelGroup);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFullName);
            Controls.Add(labelRecordBookNumber);
            Controls.Add(labelFullName);
            Name = "FormStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Студент";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelGroup;
        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxFullName;
        private Label labelRecordBookNumber;
        private Label labelFullName;
        private Label labelStatus;
        private ComboBox comboBoxGroup;
        private TextBox textBoxRecordBookNumber;
        private CheckedListBox checkedListBoxStatus;
    }
}