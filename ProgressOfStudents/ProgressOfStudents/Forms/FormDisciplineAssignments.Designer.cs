namespace ProgressOfStudents.Forms
{
    partial class FormDisciplineAssignments
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
            buttonAdd = new Button();
            dataGridViewAssignments = new DataGridView();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignments).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(633, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(167, 450);
            panelButtons.TabIndex = 7;
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
            // dataGridViewAssignments
            // 
            dataGridViewAssignments.AllowUserToAddRows = false;
            dataGridViewAssignments.AllowUserToDeleteRows = false;
            dataGridViewAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssignments.Dock = DockStyle.Fill;
            dataGridViewAssignments.Location = new Point(0, 0);
            dataGridViewAssignments.Name = "dataGridViewAssignments";
            dataGridViewAssignments.ReadOnly = true;
            dataGridViewAssignments.RowHeadersVisible = false;
            dataGridViewAssignments.RowHeadersWidth = 62;
            dataGridViewAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAssignments.Size = new Size(800, 450);
            dataGridViewAssignments.TabIndex = 6;
            // 
            // FormDisciplineAssignments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelButtons);
            Controls.Add(dataGridViewAssignments);
            Name = "FormDisciplineAssignments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ведение дисциплин";
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonAdd;
        private DataGridView dataGridViewAssignments;
    }
}