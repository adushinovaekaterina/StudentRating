namespace StudentRating.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAllSubjectsAllSemesters = new System.Windows.Forms.DataGridView();
            this.labelStudentGrades = new System.Windows.Forms.Label();
            this.labelNumericGrades = new System.Windows.Forms.Label();
            this.labelStringGrades = new System.Windows.Forms.Label();
            this.labelStudentGPA = new System.Windows.Forms.Label();
            this.labelStudentGPAForCertainSubject = new System.Windows.Forms.Label();
            this.labelStudentGradesForCertainSubject = new System.Windows.Forms.Label();
            this.labelNumericGradesForCertainSubject = new System.Windows.Forms.Label();
            this.labelStringGradesForCertainSubject = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllSubjectsAllSemesters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAllSubjectsAllSemesters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllSubjectsAllSemesters.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAllSubjectsAllSemesters.Location = new System.Drawing.Point(173, 125);
            this.dataGridViewAllSubjectsAllSemesters.Name = "dataGridViewAllSubjectsAllSemesters";
            this.dataGridViewAllSubjectsAllSemesters.ReadOnly = true;
            this.dataGridViewAllSubjectsAllSemesters.RowHeadersWidth = 56;
            this.dataGridViewAllSubjectsAllSemesters.Size = new System.Drawing.Size(961, 209);
            this.dataGridViewAllSubjectsAllSemesters.TabIndex = 0;
            // 
            // labelStudentGrades
            // 
            this.labelStudentGrades.BackColor = System.Drawing.Color.Red;
            this.labelStudentGrades.Location = new System.Drawing.Point(2, 109);
            this.labelStudentGrades.Name = "labelStudentGrades";
            this.labelStudentGrades.Size = new System.Drawing.Size(165, 100);
            this.labelStudentGrades.TabIndex = 1;
            this.labelStudentGrades.Text = "Все оценки студентов";
            // 
            // labelNumericGrades
            // 
            this.labelNumericGrades.BackColor = System.Drawing.Color.Lime;
            this.labelNumericGrades.Location = new System.Drawing.Point(2, 224);
            this.labelNumericGrades.Name = "labelNumericGrades";
            this.labelNumericGrades.Size = new System.Drawing.Size(178, 100);
            this.labelNumericGrades.TabIndex = 2;
            this.labelNumericGrades.Text = "Все численная отметки";
            // 
            // labelStringGrades
            // 
            this.labelStringGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelStringGrades.Location = new System.Drawing.Point(2, 337);
            this.labelStringGrades.Name = "labelStringGrades";
            this.labelStringGrades.Size = new System.Drawing.Size(176, 100);
            this.labelStringGrades.TabIndex = 3;
            this.labelStringGrades.Text = "Все строковые отметки";
            // 
            // labelStudentGPA
            // 
            this.labelStudentGPA.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentGPA.ForeColor = System.Drawing.Color.Black;
            this.labelStudentGPA.Location = new System.Drawing.Point(173, 95);
            this.labelStudentGPA.Name = "labelStudentGPA";
            this.labelStudentGPA.Size = new System.Drawing.Size(304, 27);
            this.labelStudentGPA.TabIndex = 4;
            this.labelStudentGPA.Text = "Ср. балл студентов в группе:";
            // 
            // labelStudentGPAForCertainSubject
            // 
            this.labelStudentGPAForCertainSubject.ForeColor = System.Drawing.Color.Black;
            this.labelStudentGPAForCertainSubject.Location = new System.Drawing.Point(2, 446);
            this.labelStudentGPAForCertainSubject.Name = "labelStudentGPAForCertainSubject";
            this.labelStudentGPAForCertainSubject.Size = new System.Drawing.Size(178, 65);
            this.labelStudentGPAForCertainSubject.TabIndex = 5;
            this.labelStudentGPAForCertainSubject.Text = "Ср. балл для ин.яз";
            // 
            // labelStudentGradesForCertainSubject
            // 
            this.labelStudentGradesForCertainSubject.BackColor = System.Drawing.Color.Red;
            this.labelStudentGradesForCertainSubject.Location = new System.Drawing.Point(2, 501);
            this.labelStudentGradesForCertainSubject.Name = "labelStudentGradesForCertainSubject";
            this.labelStudentGradesForCertainSubject.Size = new System.Drawing.Size(165, 103);
            this.labelStudentGradesForCertainSubject.TabIndex = 6;
            this.labelStudentGradesForCertainSubject.Text = "Все оценки по ин.язу";
            // 
            // labelNumericGradesForCertainSubject
            // 
            this.labelNumericGradesForCertainSubject.BackColor = System.Drawing.Color.Lime;
            this.labelNumericGradesForCertainSubject.Location = new System.Drawing.Point(2, 612);
            this.labelNumericGradesForCertainSubject.Name = "labelNumericGradesForCertainSubject";
            this.labelNumericGradesForCertainSubject.Size = new System.Drawing.Size(178, 103);
            this.labelNumericGradesForCertainSubject.TabIndex = 7;
            this.labelNumericGradesForCertainSubject.Text = "Все численные отметки по ин.язу";
            // 
            // labelStringGradesForCertainSubject
            // 
            this.labelStringGradesForCertainSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelStringGradesForCertainSubject.Location = new System.Drawing.Point(2, 726);
            this.labelStringGradesForCertainSubject.Name = "labelStringGradesForCertainSubject";
            this.labelStringGradesForCertainSubject.Size = new System.Drawing.Size(176, 103);
            this.labelStringGradesForCertainSubject.TabIndex = 8;
            this.labelStringGradesForCertainSubject.Text = "Все строковые отметки по ин.язу";
            // 
            // FormAllSubjectsAllSemesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 829);
            this.Controls.Add(this.labelStringGradesForCertainSubject);
            this.Controls.Add(this.labelNumericGradesForCertainSubject);
            this.Controls.Add(this.labelStudentGradesForCertainSubject);
            this.Controls.Add(this.labelStudentGPAForCertainSubject);
            this.Controls.Add(this.labelStudentGPA);
            this.Controls.Add(this.labelStringGrades);
            this.Controls.Add(this.labelNumericGrades);
            this.Controls.Add(this.labelStudentGrades);
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
        private System.Windows.Forms.Label labelStudentGrades;
        private System.Windows.Forms.Label labelNumericGrades;
        private System.Windows.Forms.Label labelStringGrades;
        private System.Windows.Forms.Label labelStudentGPA;
        private System.Windows.Forms.Label labelStudentGPAForCertainSubject;
        private System.Windows.Forms.Label labelStudentGradesForCertainSubject;
        private System.Windows.Forms.Label labelNumericGradesForCertainSubject;
        private System.Windows.Forms.Label labelStringGradesForCertainSubject;
    }
}