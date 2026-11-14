namespace ProgressOfStudents
{
    partial class FormDeanery : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            DeanOfficesToolStripMenuItem = new ToolStripMenuItem();
            DepartmentsToolStripMenuItem = new ToolStripMenuItem();
            DisciplinesToolStripMenuItem = new ToolStripMenuItem();
            TeachersToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            StreamsToolStripMenuItem = new ToolStripMenuItem();
            GroupsToolStripMenuItem = new ToolStripMenuItem();
            StudentsToolStripMenuItem = new ToolStripMenuItem();
            AssignmentsToolStripMenuItem = new ToolStripMenuItem();
            PerformancesToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчетыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DeanOfficesToolStripMenuItem, DepartmentsToolStripMenuItem, DisciplinesToolStripMenuItem, TeachersToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(139, 29);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // DeanOfficesToolStripMenuItem
            // 
            DeanOfficesToolStripMenuItem.Name = "DeanOfficesToolStripMenuItem";
            DeanOfficesToolStripMenuItem.Size = new Size(241, 34);
            DeanOfficesToolStripMenuItem.Text = "Деканаты";
            DeanOfficesToolStripMenuItem.Click += DeanOfficesToolStripMenuItem_Click;
            // 
            // DepartmentsToolStripMenuItem
            // 
            DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem";
            DepartmentsToolStripMenuItem.Size = new Size(241, 34);
            DepartmentsToolStripMenuItem.Text = "Кафедры";
            DepartmentsToolStripMenuItem.Click += DepartmentsToolStripMenuItem_Click;
            // 
            // DisciplinesToolStripMenuItem
            // 
            DisciplinesToolStripMenuItem.Name = "DisciplinesToolStripMenuItem";
            DisciplinesToolStripMenuItem.Size = new Size(241, 34);
            DisciplinesToolStripMenuItem.Text = "Дисциплины";
            DisciplinesToolStripMenuItem.Click += DisciplinesToolStripMenuItem_Click;
            // 
            // TeachersToolStripMenuItem
            // 
            TeachersToolStripMenuItem.Name = "TeachersToolStripMenuItem";
            TeachersToolStripMenuItem.Size = new Size(241, 34);
            TeachersToolStripMenuItem.Text = "Преподаватели";
            TeachersToolStripMenuItem.Click += TeachersToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StreamsToolStripMenuItem, GroupsToolStripMenuItem, StudentsToolStripMenuItem, AssignmentsToolStripMenuItem, PerformancesToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(112, 29);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // StreamsToolStripMenuItem
            // 
            StreamsToolStripMenuItem.Name = "StreamsToolStripMenuItem";
            StreamsToolStripMenuItem.Size = new Size(274, 34);
            StreamsToolStripMenuItem.Text = "Потоки";
            StreamsToolStripMenuItem.Click += StreamsToolStripMenuItem_Click;
            // 
            // GroupsToolStripMenuItem
            // 
            GroupsToolStripMenuItem.Name = "GroupsToolStripMenuItem";
            GroupsToolStripMenuItem.Size = new Size(274, 34);
            GroupsToolStripMenuItem.Text = "Группы";
            GroupsToolStripMenuItem.Click += GroupsToolStripMenuItem_Click;
            // 
            // StudentsToolStripMenuItem
            // 
            StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
            StudentsToolStripMenuItem.Size = new Size(274, 34);
            StudentsToolStripMenuItem.Text = "Студенты";
            StudentsToolStripMenuItem.Click += StudentsToolStripMenuItem_Click;
            // 
            // AssignmentsToolStripMenuItem
            // 
            AssignmentsToolStripMenuItem.Name = "AssignmentsToolStripMenuItem";
            AssignmentsToolStripMenuItem.Size = new Size(274, 34);
            AssignmentsToolStripMenuItem.Text = "Ведение дисциплин";
            AssignmentsToolStripMenuItem.Click += AssignmentsToolStripMenuItem_Click;
            // 
            // PerformancesToolStripMenuItem
            // 
            PerformancesToolStripMenuItem.Name = "PerformancesToolStripMenuItem";
            PerformancesToolStripMenuItem.Size = new Size(274, 34);
            PerformancesToolStripMenuItem.Text = "Успеваемость";
            PerformancesToolStripMenuItem.Click += PerformancesToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(88, 29);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // FormDeanery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Фон_для_главной_формы;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormDeanery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет успеваемости студентов";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem DeanOfficesToolStripMenuItem;
        private ToolStripMenuItem DepartmentsToolStripMenuItem;
        private ToolStripMenuItem DisciplinesToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem TeachersToolStripMenuItem;
        private ToolStripMenuItem StreamsToolStripMenuItem;
        private ToolStripMenuItem GroupsToolStripMenuItem;
        private ToolStripMenuItem StudentsToolStripMenuItem;
        private ToolStripMenuItem AssignmentsToolStripMenuItem;
        private ToolStripMenuItem PerformancesToolStripMenuItem;
    }
}
