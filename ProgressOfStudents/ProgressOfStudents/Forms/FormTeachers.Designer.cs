namespace ProgressOfStudents.Forms
{
    partial class FormTeachers
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
            buttonUpd = new Button();
            buttonAdd = new Button();
            dataGridViewTeachers = new DataGridView();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonDel);
            panelButtons.Controls.Add(buttonUpd);
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(633, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(167, 450);
            panelButtons.TabIndex = 5;
            // 
            // buttonDel
            // 
            buttonDel.BackgroundImage = Properties.Resources.кнопка_удаления;
            buttonDel.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDel.Location = new Point(32, 263);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(100, 100);
            buttonDel.TabIndex = 2;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.BackgroundImage = Properties.Resources.кнопка_изменения;
            buttonUpd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUpd.Location = new Point(32, 148);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(100, 100);
            buttonUpd.TabIndex = 1;
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += buttonUpd_Click;
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
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.AllowUserToAddRows = false;
            dataGridViewTeachers.AllowUserToDeleteRows = false;
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers.Dock = DockStyle.Fill;
            dataGridViewTeachers.Location = new Point(0, 0);
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewTeachers.ReadOnly = true;
            dataGridViewTeachers.RowHeadersVisible = false;
            dataGridViewTeachers.RowHeadersWidth = 62;
            dataGridViewTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTeachers.Size = new Size(800, 450);
            dataGridViewTeachers.TabIndex = 4;
            // 
            // FormTeachers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelButtons);
            Controls.Add(dataGridViewTeachers);
            Name = "FormTeachers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Преподаватели";
            Load += FormTeachers_Load;
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonDel;
        private Button buttonUpd;
        private Button buttonAdd;
        private DataGridView dataGridViewTeachers;
    }
}