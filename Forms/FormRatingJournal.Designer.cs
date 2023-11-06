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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelFIOStudent = new System.Windows.Forms.Label();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelStudentRating = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(333, 897);
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
            this.buttonExit.Location = new System.Drawing.Point(0, 786);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.buttonExit.Size = new System.Drawing.Size(333, 111);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Tag = "Выйти из аккаунта";
            this.buttonExit.Text = "Выйти из аккаунта";
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
            this.buttonCertainSubject.Location = new System.Drawing.Point(0, 357);
            this.buttonCertainSubject.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCertainSubject.Name = "buttonCertainSubject";
            this.buttonCertainSubject.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.buttonCertainSubject.Size = new System.Drawing.Size(333, 111);
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
            this.buttonCertainSemester.Location = new System.Drawing.Point(0, 246);
            this.buttonCertainSemester.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCertainSemester.Name = "buttonCertainSemester";
            this.buttonCertainSemester.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.buttonCertainSemester.Size = new System.Drawing.Size(333, 111);
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
            this.buttonAllSubjectsAllSemesters.Location = new System.Drawing.Point(0, 135);
            this.buttonAllSubjectsAllSemesters.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllSubjectsAllSemesters.Name = "buttonAllSubjectsAllSemesters";
            this.buttonAllSubjectsAllSemesters.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.buttonAllSubjectsAllSemesters.Size = new System.Drawing.Size(333, 111);
            this.buttonAllSubjectsAllSemesters.TabIndex = 1;
            this.buttonAllSubjectsAllSemesters.Tag = "   По всем     предметам за все семестры ";
            this.buttonAllSubjectsAllSemesters.Text = "   По всем\r\n   предметам \r\n   за все семестры";
            this.buttonAllSubjectsAllSemesters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAllSubjectsAllSemesters.UseVisualStyleBackColor = true;
            this.buttonAllSubjectsAllSemesters.Click += new System.EventHandler(this.buttonAllSubjectsAllSemesters_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.labelFIOStudent);
            this.panelTitleBar.Controls.Add(this.labelTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(333, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1467, 86);
            this.panelTitleBar.TabIndex = 2;
            // 
            // labelFIOStudent
            // 
            this.labelFIOStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelFIOStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFIOStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIOStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.labelFIOStudent.Location = new System.Drawing.Point(980, 0);
            this.labelFIOStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFIOStudent.Name = "labelFIOStudent";
            this.labelFIOStudent.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.labelFIOStudent.Size = new System.Drawing.Size(483, 86);
            this.labelFIOStudent.TabIndex = 7;
            this.labelFIOStudent.Text = "ФИО студента";
            this.labelFIOStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleBar.ForeColor = System.Drawing.Color.Black;
            this.labelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.labelTitleBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelTitleBar.Size = new System.Drawing.Size(980, 86);
            this.labelTitleBar.TabIndex = 6;
            this.labelTitleBar.Text = "ЖУРНАЛ РЕЙТИНГА";
            this.labelTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(333, 0);
            this.panelWorkspace.Margin = new System.Windows.Forms.Padding(4);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(1467, 897);
            this.panelWorkspace.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelLogo.Controls.Add(this.labelStudentRating);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(333, 135);
            this.panelLogo.TabIndex = 0;
            // 
            // labelStudentRating
            // 
            this.labelStudentRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentRating.Location = new System.Drawing.Point(45, 19);
            this.labelStudentRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentRating.Name = "labelStudentRating";
            this.labelStudentRating.Size = new System.Drawing.Size(241, 97);
            this.labelStudentRating.TabIndex = 1;
            this.labelStudentRating.Text = "Рейтинг студентов";
            this.labelStudentRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRatingJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1274, 456);
            this.Name = "FormRatingJournal";
            this.Text = "Журнал рейтинга студентов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRatingJournal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAllSubjectsAllSemesters;
        private System.Windows.Forms.Button buttonCertainSemester;
        private System.Windows.Forms.Button buttonCertainSubject;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitleBar;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Label labelFIOStudent;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelStudentRating;
    }
}