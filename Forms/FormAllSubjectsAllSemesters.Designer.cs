﻿namespace StudentRating.Forms
{
    partial class FormAllSubjectsAllSemesters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAllSubjectsAllSemesters = new System.Windows.Forms.DataGridView();
            this.labelStudentsGPA = new System.Windows.Forms.Label();
            this.labelStudentGPA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSubjectsAllSemesters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllSubjectsAllSemesters
            // 
            this.dataGridViewAllSubjectsAllSemesters.AllowUserToAddRows = false;
            this.dataGridViewAllSubjectsAllSemesters.AllowUserToDeleteRows = false;
            this.dataGridViewAllSubjectsAllSemesters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllSubjectsAllSemesters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAllSubjectsAllSemesters.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllSubjectsAllSemesters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAllSubjectsAllSemesters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAllSubjectsAllSemesters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllSubjectsAllSemesters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllSubjectsAllSemesters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllSubjectsAllSemesters.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAllSubjectsAllSemesters.Location = new System.Drawing.Point(41, 143);
            this.dataGridViewAllSubjectsAllSemesters.Name = "dataGridViewAllSubjectsAllSemesters";
            this.dataGridViewAllSubjectsAllSemesters.ReadOnly = true;
            this.dataGridViewAllSubjectsAllSemesters.RowHeadersWidth = 56;
            this.dataGridViewAllSubjectsAllSemesters.Size = new System.Drawing.Size(1093, 665);
            this.dataGridViewAllSubjectsAllSemesters.TabIndex = 0;
            // 
            // labelStudentsGPA
            // 
            this.labelStudentsGPA.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentsGPA.ForeColor = System.Drawing.Color.Black;
            this.labelStudentsGPA.Location = new System.Drawing.Point(36, 97);
            this.labelStudentsGPA.Name = "labelStudentsGPA";
            this.labelStudentsGPA.Size = new System.Drawing.Size(449, 27);
            this.labelStudentsGPA.TabIndex = 4;
            this.labelStudentsGPA.Text = "Средний балл студентов в группе ";
            // 
            // labelStudentGPA
            // 
            this.labelStudentGPA.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentGPA.ForeColor = System.Drawing.Color.Black;
            this.labelStudentGPA.Location = new System.Drawing.Point(867, 97);
            this.labelStudentGPA.Name = "labelStudentGPA";
            this.labelStudentGPA.Size = new System.Drawing.Size(267, 27);
            this.labelStudentGPA.TabIndex = 5;
            this.labelStudentGPA.Text = "Мой средний балл: ";
            // 
            // FormAllSubjectsAllSemesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1205, 829);
            this.Controls.Add(this.labelStudentGPA);
            this.Controls.Add(this.labelStudentsGPA);
            this.Controls.Add(this.dataGridViewAllSubjectsAllSemesters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAllSubjectsAllSemesters";
            this.Text = "ЖУРНАЛ РЕЙТИНГА СТУДЕНТОВ ПО ВСЕМ ПРЕДМЕТАМ ЗА ВСЕ СЕМЕСТРЫ";
            this.Load += new System.EventHandler(this.FormAllSubjectsAllSemesters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSubjectsAllSemesters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewAllSubjectsAllSemesters;
        private System.Windows.Forms.Label labelStudentsGPA;
        private System.Windows.Forms.Label labelStudentGPA;
    }
}