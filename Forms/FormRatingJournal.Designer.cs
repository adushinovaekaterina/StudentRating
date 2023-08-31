namespace StudentRating
{
    partial class FormRatingJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRatingJournal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCertainSubject = new System.Windows.Forms.Button();
            this.buttonCertainSemester = new System.Windows.Forms.Button();
            this.buttonAllSubjectsAllSemesters = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelNameStudent = new System.Windows.Forms.Label();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonCertainSubject);
            this.panelMenu.Controls.Add(this.buttonCertainSemester);
            this.panelMenu.Controls.Add(this.buttonAllSubjectsAllSemesters);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 729);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = global::StudentRating.Properties.Resources.exit_svgrepo_com;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 639);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonExit.Size = new System.Drawing.Size(250, 90);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Tag = "Выйти из личного кабинета";
            this.buttonExit.Text = "Выйти из личного кабинета";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCertainSubject
            // 
            this.buttonCertainSubject.AutoSize = true;
            this.buttonCertainSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCertainSubject.FlatAppearance.BorderSize = 0;
            this.buttonCertainSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCertainSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCertainSubject.ForeColor = System.Drawing.Color.White;
            this.buttonCertainSubject.Image = global::StudentRating.Properties.Resources.open_book_svgrepo_com__7_;
            this.buttonCertainSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCertainSubject.Location = new System.Drawing.Point(0, 290);
            this.buttonCertainSubject.Name = "buttonCertainSubject";
            this.buttonCertainSubject.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonCertainSubject.Size = new System.Drawing.Size(250, 90);
            this.buttonCertainSubject.TabIndex = 3;
            this.buttonCertainSubject.Tag = "По определенному предмету";
            this.buttonCertainSubject.Text = " По определенному предмету";
            this.buttonCertainSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCertainSubject.UseVisualStyleBackColor = true;
            this.buttonCertainSubject.Click += new System.EventHandler(this.buttonCertainSubject_Click);
            // 
            // buttonCertainSemester
            // 
            this.buttonCertainSemester.AutoSize = true;
            this.buttonCertainSemester.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCertainSemester.FlatAppearance.BorderSize = 0;
            this.buttonCertainSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCertainSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCertainSemester.ForeColor = System.Drawing.Color.White;
            this.buttonCertainSemester.Image = global::StudentRating.Properties.Resources.academic_calendar_svgrepo_com__3___1_;
            this.buttonCertainSemester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCertainSemester.Location = new System.Drawing.Point(0, 200);
            this.buttonCertainSemester.Name = "buttonCertainSemester";
            this.buttonCertainSemester.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonCertainSemester.Size = new System.Drawing.Size(250, 90);
            this.buttonCertainSemester.TabIndex = 2;
            this.buttonCertainSemester.Tag = "За определенный семестр";
            this.buttonCertainSemester.Text = "  За определенный семестр";
            this.buttonCertainSemester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCertainSemester.UseVisualStyleBackColor = true;
            this.buttonCertainSemester.Click += new System.EventHandler(this.buttonCertainSemester_Click);
            // 
            // buttonAllSubjectsAllSemesters
            // 
            this.buttonAllSubjectsAllSemesters.AutoSize = true;
            this.buttonAllSubjectsAllSemesters.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllSubjectsAllSemesters.FlatAppearance.BorderSize = 0;
            this.buttonAllSubjectsAllSemesters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllSubjectsAllSemesters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllSubjectsAllSemesters.ForeColor = System.Drawing.Color.White;
            this.buttonAllSubjectsAllSemesters.Image = global::StudentRating.Properties.Resources.books_svgrepo_com__11_;
            this.buttonAllSubjectsAllSemesters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllSubjectsAllSemesters.Location = new System.Drawing.Point(0, 110);
            this.buttonAllSubjectsAllSemesters.Name = "buttonAllSubjectsAllSemesters";
            this.buttonAllSubjectsAllSemesters.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonAllSubjectsAllSemesters.Size = new System.Drawing.Size(250, 90);
            this.buttonAllSubjectsAllSemesters.TabIndex = 1;
            this.buttonAllSubjectsAllSemesters.Tag = "   По всем     предметам за все семестры ";
            this.buttonAllSubjectsAllSemesters.Text = "   По всем\r\n   предметам \r\n   за все семестры";
            this.buttonAllSubjectsAllSemesters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAllSubjectsAllSemesters.UseVisualStyleBackColor = true;
            this.buttonAllSubjectsAllSemesters.Click += new System.EventHandler(this.buttonAllSubjectsAllSemesters_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.buttonMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 110);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Обычный", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рейтинг студентов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Image = global::StudentRating.Properties.Resources.menu_svgrepo_com__4_;
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(100, 110);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.labelNameStudent);
            this.panelTitleBar.Controls.Add(this.labelTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1100, 70);
            this.panelTitleBar.TabIndex = 2;
            // 
            // labelNameStudent
            // 
            this.labelNameStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelNameStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.labelNameStudent.Location = new System.Drawing.Point(735, 0);
            this.labelNameStudent.Name = "labelNameStudent";
            this.labelNameStudent.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.labelNameStudent.Size = new System.Drawing.Size(362, 70);
            this.labelNameStudent.TabIndex = 7;
            this.labelNameStudent.Text = "Имя студента";
            this.labelNameStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleBar.ForeColor = System.Drawing.Color.Black;
            this.labelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelTitleBar.Size = new System.Drawing.Size(735, 70);
            this.labelTitleBar.TabIndex = 6;
            this.labelTitleBar.Text = "ЖУРНАЛ РЕЙТИНГА СТУДЕНТОВ ПО ВСЕМ ПРЕДМЕТАМ ЗА ВСЕ СЕМЕСТРЫ";
            this.labelTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(250, 0);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1100, 729);
            this.panelDesktopPanel.TabIndex = 3;
            // 
            // FormRatingJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 380);
            this.Name = "FormRatingJournal";
            this.Text = "Журнал рейтинга студентов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRatingJournal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAllSubjectsAllSemesters;
        private System.Windows.Forms.Button buttonCertainSemester;
        private System.Windows.Forms.Button buttonCertainSubject;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelTitleBar;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Label labelNameStudent;
    }
}