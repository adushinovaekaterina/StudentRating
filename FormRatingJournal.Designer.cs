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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonCertainSubject = new System.Windows.Forms.Button();
            this.buttonCertainSemester = new System.Windows.Forms.Button();
            this.buttonAllSubjectsAllSemesters = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelStudentRating = new System.Windows.Forms.Label();
            this.pictureBoxIconStudentRating = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconStudentRating)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
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
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelLogo.Controls.Add(this.labelStudentRating);
            this.panelLogo.Controls.Add(this.pictureBoxIconStudentRating);
            this.panelLogo.Controls.Add(this.buttonMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 145);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.buttonClose);
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.labelTitleBar);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1100, 70);
            this.panelTitleBar.TabIndex = 2;
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.BackColor = System.Drawing.Color.White;
            this.labelTitleBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleBar.ForeColor = System.Drawing.Color.Black;
            this.labelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.labelTitleBar.Size = new System.Drawing.Size(735, 70);
            this.labelTitleBar.TabIndex = 6;
            this.labelTitleBar.Text = "ЖУРНАЛ РЕЙТИНГА СТУДЕНТОВ ПО ВСЕМ ПРЕДМЕТАМ ЗА ВСЕ СЕМЕСТРЫ";
            this.labelTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 23);
            this.labelTitle.TabIndex = 7;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(250, 70);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1100, 659);
            this.panelDesktopPanel.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::StudentRating.Properties.Resources.close_svgrepo_com__2_;
            this.buttonClose.Location = new System.Drawing.Point(1057, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 25);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(196)))));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::StudentRating.Properties.Resources.horizontal_rule_svgrepo_com;
            this.buttonMinimize.Location = new System.Drawing.Point(977, 6);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(40, 25);
            this.buttonMinimize.TabIndex = 5;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = global::StudentRating.Properties.Resources.expand_svgrepo_com;
            this.buttonMaximize.Location = new System.Drawing.Point(1017, 6);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(40, 25);
            this.buttonMaximize.TabIndex = 4;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonCertainSubject
            // 
            this.buttonCertainSubject.AutoSize = true;
            this.buttonCertainSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCertainSubject.FlatAppearance.BorderSize = 0;
            this.buttonCertainSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCertainSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCertainSubject.ForeColor = System.Drawing.Color.White;
            this.buttonCertainSubject.Image = global::StudentRating.Properties.Resources.open_book_svgrepo_com__3_;
            this.buttonCertainSubject.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCertainSubject.Location = new System.Drawing.Point(0, 295);
            this.buttonCertainSubject.Name = "buttonCertainSubject";
            this.buttonCertainSubject.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonCertainSubject.Size = new System.Drawing.Size(250, 75);
            this.buttonCertainSubject.TabIndex = 3;
            this.buttonCertainSubject.Tag = "По определенному предмету";
            this.buttonCertainSubject.Text = "  По определенному предмету";
            this.buttonCertainSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCertainSubject.UseVisualStyleBackColor = true;
            // 
            // buttonCertainSemester
            // 
            this.buttonCertainSemester.AutoSize = true;
            this.buttonCertainSemester.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCertainSemester.FlatAppearance.BorderSize = 0;
            this.buttonCertainSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCertainSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCertainSemester.ForeColor = System.Drawing.Color.White;
            this.buttonCertainSemester.Image = global::StudentRating.Properties.Resources.academic_calendar_svgrepo_com__1___1_;
            this.buttonCertainSemester.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCertainSemester.Location = new System.Drawing.Point(0, 220);
            this.buttonCertainSemester.Name = "buttonCertainSemester";
            this.buttonCertainSemester.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonCertainSemester.Size = new System.Drawing.Size(250, 75);
            this.buttonCertainSemester.TabIndex = 2;
            this.buttonCertainSemester.Tag = "За определенный семестр";
            this.buttonCertainSemester.Text = "  За определенный семестр";
            this.buttonCertainSemester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCertainSemester.UseVisualStyleBackColor = true;
            // 
            // buttonAllSubjectsAllSemesters
            // 
            this.buttonAllSubjectsAllSemesters.AutoSize = true;
            this.buttonAllSubjectsAllSemesters.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllSubjectsAllSemesters.FlatAppearance.BorderSize = 0;
            this.buttonAllSubjectsAllSemesters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllSubjectsAllSemesters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllSubjectsAllSemesters.ForeColor = System.Drawing.Color.White;
            this.buttonAllSubjectsAllSemesters.Image = global::StudentRating.Properties.Resources.books_svgrepo_com__3_;
            this.buttonAllSubjectsAllSemesters.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAllSubjectsAllSemesters.Location = new System.Drawing.Point(0, 145);
            this.buttonAllSubjectsAllSemesters.Name = "buttonAllSubjectsAllSemesters";
            this.buttonAllSubjectsAllSemesters.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonAllSubjectsAllSemesters.Size = new System.Drawing.Size(250, 75);
            this.buttonAllSubjectsAllSemesters.TabIndex = 1;
            this.buttonAllSubjectsAllSemesters.Tag = "   По всем     предметам за все семестры ";
            this.buttonAllSubjectsAllSemesters.Text = "   По всем\r\n   предметам \r\n   за все семестры";
            this.buttonAllSubjectsAllSemesters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAllSubjectsAllSemesters.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Image = global::StudentRating.Properties.Resources.menu_svgrepo_com__4_;
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(100, 145);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelStudentRating
            // 
            this.labelStudentRating.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStudentRating.Font = new System.Drawing.Font("Обычный", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentRating.ForeColor = System.Drawing.Color.White;
            this.labelStudentRating.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelStudentRating.Location = new System.Drawing.Point(102, 91);
            this.labelStudentRating.Name = "labelStudentRating";
            this.labelStudentRating.Size = new System.Drawing.Size(124, 34);
            this.labelStudentRating.TabIndex = 2;
            this.labelStudentRating.Text = "Рейтинг студентов";
            this.labelStudentRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIconStudentRating
            // 
            this.pictureBoxIconStudentRating.Image = global::StudentRating.Properties.Resources.certificated_toga_diploma_university_school_graduated_icon_209310;
            this.pictureBoxIconStudentRating.Location = new System.Drawing.Point(112, 15);
            this.pictureBoxIconStudentRating.Name = "pictureBoxIconStudentRating";
            this.pictureBoxIconStudentRating.Size = new System.Drawing.Size(100, 73);
            this.pictureBoxIconStudentRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIconStudentRating.TabIndex = 3;
            this.pictureBoxIconStudentRating.TabStop = false;
            // 
            // FormRatingJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRatingJournal";
            this.Text = "Журнал рейтинга студентов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconStudentRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAllSubjectsAllSemesters;
        private System.Windows.Forms.Button buttonCertainSemester;
        private System.Windows.Forms.Button buttonCertainSubject;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label labelTitleBar;
        private System.Windows.Forms.Label labelStudentRating;
        private System.Windows.Forms.PictureBox pictureBoxIconStudentRating;
    }
}