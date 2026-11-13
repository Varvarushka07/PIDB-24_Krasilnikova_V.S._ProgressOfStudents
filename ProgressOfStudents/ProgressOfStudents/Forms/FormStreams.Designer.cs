namespace ProgressOfStudents.Forms
{
    partial class FormStreams
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
            dataGridViewStreams = new DataGridView();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStreams).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(633, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(167, 450);
            panelButtons.TabIndex = 5;
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
            // dataGridViewStreams
            // 
            dataGridViewStreams.AllowUserToAddRows = false;
            dataGridViewStreams.AllowUserToDeleteRows = false;
            dataGridViewStreams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStreams.Dock = DockStyle.Fill;
            dataGridViewStreams.Location = new Point(0, 0);
            dataGridViewStreams.Name = "dataGridViewStreams";
            dataGridViewStreams.ReadOnly = true;
            dataGridViewStreams.RowHeadersVisible = false;
            dataGridViewStreams.RowHeadersWidth = 62;
            dataGridViewStreams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStreams.Size = new Size(800, 450);
            dataGridViewStreams.TabIndex = 4;
            // 
            // FormStreams
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelButtons);
            Controls.Add(dataGridViewStreams);
            Name = "FormStreams";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Потоки";
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStreams).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonAdd;
        private DataGridView dataGridViewStreams;
    }
}