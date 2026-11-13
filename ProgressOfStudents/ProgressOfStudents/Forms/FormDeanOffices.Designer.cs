namespace ProgressOfStudents.Forms
{
    partial class FormDeanOffices
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
            dataGridViewDeanOffices = new DataGridView();
            panelButtons = new Panel();
            buttonAdd = new Button();
            buttonUpd = new Button();
            this.buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeanOffices).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDeanOffices
            // 
            dataGridViewDeanOffices.AllowUserToAddRows = false;
            dataGridViewDeanOffices.AllowUserToDeleteRows = false;
            dataGridViewDeanOffices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeanOffices.Dock = DockStyle.Fill;
            dataGridViewDeanOffices.Location = new Point(0, 0);
            dataGridViewDeanOffices.Name = "dataGridViewDeanOffices";
            dataGridViewDeanOffices.ReadOnly = true;
            dataGridViewDeanOffices.RowHeadersVisible = false;
            dataGridViewDeanOffices.RowHeadersWidth = 62;
            dataGridViewDeanOffices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDeanOffices.Size = new Size(800, 450);
            dataGridViewDeanOffices.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(this.buttonDel);
            panelButtons.Controls.Add(buttonUpd);
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(633, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(167, 450);
            panelButtons.TabIndex = 1;
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
            // buttonDel
            // 
            this.buttonDel.BackgroundImage = Properties.Resources.кнопка_удаления;
            this.buttonDel.BackgroundImageLayout = ImageLayout.Zoom;
            this.buttonDel.Location = new Point(32, 263);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new Size(100, 100);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += this.buttonDel_Click;
            // 
            // FormDeanOffices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelButtons);
            Controls.Add(dataGridViewDeanOffices);
            Name = "FormDeanOffices";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Деканаты";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeanOffices).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDeanOffices;
        private Panel panelButtons;
        private Button buttonDel;
        private Button buttonUpd;
        private Button buttonAdd;
    }
}