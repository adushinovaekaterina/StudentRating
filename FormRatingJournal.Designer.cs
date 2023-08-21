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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCertainSemester = new System.Windows.Forms.Button();
            this.buttonAllSubjectsAllSemesters = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelStudentRating = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.buttonCertainSemester);
            this.panelMenu.Controls.Add(this.buttonAllSubjectsAllSemesters);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 729);
            this.panelMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::StudentRating.Properties.Resources.open_book_svgrepo_com__3_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(0, 230);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(250, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "  По определенному предмету";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
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
            this.buttonCertainSemester.Location = new System.Drawing.Point(0, 155);
            this.buttonCertainSemester.Name = "buttonCertainSemester";
            this.buttonCertainSemester.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonCertainSemester.Size = new System.Drawing.Size(250, 75);
            this.buttonCertainSemester.TabIndex = 2;
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
            this.buttonAllSubjectsAllSemesters.Location = new System.Drawing.Point(0, 80);
            this.buttonAllSubjectsAllSemesters.Name = "buttonAllSubjectsAllSemesters";
            this.buttonAllSubjectsAllSemesters.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonAllSubjectsAllSemesters.Size = new System.Drawing.Size(250, 75);
            this.buttonAllSubjectsAllSemesters.TabIndex = 1;
            this.buttonAllSubjectsAllSemesters.Text = "   По всем\r\n   предметам \r\n   за все семестры";
            this.buttonAllSubjectsAllSemesters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAllSubjectsAllSemesters.UseVisualStyleBackColor = true;
            this.buttonAllSubjectsAllSemesters.Click += new System.EventHandler(this.buttonAllSubjectsAllSemesters_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelStudentRating);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // labelStudentRating
            // 
            this.labelStudentRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStudentRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStudentRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentRating.Location = new System.Drawing.Point(0, 0);
            this.labelStudentRating.Name = "labelStudentRating";
            this.labelStudentRating.Size = new System.Drawing.Size(250, 80);
            this.labelStudentRating.TabIndex = 0;
            this.labelStudentRating.Text = "Рейтинг студентов";
            this.labelStudentRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1100, 80);
            this.panelTitleBar.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1100, 80);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(250, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1100, 649);
            this.panelDesktopPanel.TabIndex = 3;
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
            this.Name = "FormRatingJournal";
            this.Text = "Журнал рейтинга студентов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelStudentRating;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}