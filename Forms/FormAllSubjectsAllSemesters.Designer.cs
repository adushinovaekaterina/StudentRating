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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAllSubjectsAllSemesters = new System.Windows.Forms.DataGridView();
            this.labelStudentGrades = new System.Windows.Forms.Label();
            this.labelNumericGrades = new System.Windows.Forms.Label();
            this.labelStringGrades = new System.Windows.Forms.Label();
            this.labelStudentGPA = new System.Windows.Forms.Label();
            this.labelStudentGPAForCertainSubject = new System.Windows.Forms.Label();
            this.labelStudentGradesForCertainSubject = new System.Windows.Forms.Label();
            this.labelNumericGradesForCertainSubject = new System.Windows.Forms.Label();
            this.labelStringGradesForCertainSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllSubjectsAllSemesters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAllSubjectsAllSemesters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllSubjectsAllSemesters.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAllSubjectsAllSemesters.Location = new System.Drawing.Point(173, 125);
            this.dataGridViewAllSubjectsAllSemesters.Name = "dataGridViewAllSubjectsAllSemesters";
            this.dataGridViewAllSubjectsAllSemesters.ReadOnly = true;
            this.dataGridViewAllSubjectsAllSemesters.RowHeadersWidth = 56;
            this.dataGridViewAllSubjectsAllSemesters.Size = new System.Drawing.Size(878, 209);
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
            this.labelStudentGPAForCertainSubject.Location = new System.Drawing.Point(196, 337);
            this.labelStudentGPAForCertainSubject.Name = "labelStudentGPAForCertainSubject";
            this.labelStudentGPAForCertainSubject.Size = new System.Drawing.Size(281, 30);
            this.labelStudentGPAForCertainSubject.TabIndex = 5;
            this.labelStudentGPAForCertainSubject.Text = "Ср. балл для ин.яз";
            // 
            // labelStudentGradesForCertainSubject
            // 
            this.labelStudentGradesForCertainSubject.BackColor = System.Drawing.Color.Red;
            this.labelStudentGradesForCertainSubject.Location = new System.Drawing.Point(196, 367);
            this.labelStudentGradesForCertainSubject.Name = "labelStudentGradesForCertainSubject";
            this.labelStudentGradesForCertainSubject.Size = new System.Drawing.Size(165, 100);
            this.labelStudentGradesForCertainSubject.TabIndex = 6;
            this.labelStudentGradesForCertainSubject.Text = "Все оценки по ин.язу";
            // 
            // labelNumericGradesForCertainSubject
            // 
            this.labelNumericGradesForCertainSubject.BackColor = System.Drawing.Color.Lime;
            this.labelNumericGradesForCertainSubject.Location = new System.Drawing.Point(196, 478);
            this.labelNumericGradesForCertainSubject.Name = "labelNumericGradesForCertainSubject";
            this.labelNumericGradesForCertainSubject.Size = new System.Drawing.Size(178, 100);
            this.labelNumericGradesForCertainSubject.TabIndex = 7;
            this.labelNumericGradesForCertainSubject.Text = "Все численные отметки по ин.язу";
            // 
            // labelStringGradesForCertainSubject
            // 
            this.labelStringGradesForCertainSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelStringGradesForCertainSubject.Location = new System.Drawing.Point(196, 592);
            this.labelStringGradesForCertainSubject.Name = "labelStringGradesForCertainSubject";
            this.labelStringGradesForCertainSubject.Size = new System.Drawing.Size(176, 100);
            this.labelStringGradesForCertainSubject.TabIndex = 8;
            this.labelStringGradesForCertainSubject.Text = "Все строковые отметки по ин.язу";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(524, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 100);
            this.label1.TabIndex = 9;
            this.label1.Text = "Все оценки студентов";
            // 
            // FormAllSubjectsAllSemesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}