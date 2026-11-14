namespace ProgressOfStudents.Forms
{
    partial class FormStudents
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
            panelButtons = new Panel();
            buttonDel = new Button();
            buttonAdd = new Button();
            dataGridViewStudents = new DataGridView();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonDel);
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(633, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(167, 450);
            panelButtons.TabIndex = 7;
            // 
            // buttonDel
            // 
            buttonDel.BackgroundImage = Properties.Resources.кнопка_удаления;
            buttonDel.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDel.Location = new Point(32, 187);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(100, 100);
            buttonDel.TabIndex = 2;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.кнопка_добавления;
            buttonAdd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdd.Location = new Point(32, 32);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 100);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseMnemonic = false;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Dock = DockStyle.Fill;
            dataGridViewStudents.Location = new Point(0, 0);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersVisible = false;
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.Size = new Size(800, 450);
            dataGridViewStudents.TabIndex = 6;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelButtons);
            Controls.Add(dataGridViewStudents);
            Name = "FormStudents";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Студенты";
            Load += FormStudents_Load;
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonDel;
        private Button buttonAdd;
        private DataGridView dataGridViewStudents;
    }
}