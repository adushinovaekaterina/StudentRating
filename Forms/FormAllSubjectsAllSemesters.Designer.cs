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
            this.labelNumericGrade = new System.Windows.Forms.Label();
            this.labelStringGrade = new System.Windows.Forms.Label();
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
            this.dataGridViewAllSubjectsAllSemesters.Location = new System.Drawing.Point(173, 109);
            this.dataGridViewAllSubjectsAllSemesters.Name = "dataGridViewAllSubjectsAllSemesters";
            this.dataGridViewAllSubjectsAllSemesters.ReadOnly = true;
            this.dataGridViewAllSubjectsAllSemesters.Size = new System.Drawing.Size(785, 551);
            this.dataGridViewAllSubjectsAllSemesters.TabIndex = 0;
            // 
            // labelStudentGrades
            // 
            this.labelStudentGrades.BackColor = System.Drawing.Color.Red;
            this.labelStudentGrades.Location = new System.Drawing.Point(2, 109);
            this.labelStudentGrades.Name = "labelStudentGrades";
            this.labelStudentGrades.Size = new System.Drawing.Size(165, 100);
            this.labelStudentGrades.TabIndex = 1;
            this.labelStudentGrades.Text = "Оценки студентов";
            // 
            // labelNumericGrade
            // 
            this.labelNumericGrade.BackColor = System.Drawing.Color.Lime;
            this.labelNumericGrade.Location = new System.Drawing.Point(2, 224);
            this.labelNumericGrade.Name = "labelNumericGrade";
            this.labelNumericGrade.Size = new System.Drawing.Size(178, 100);
            this.labelNumericGrade.TabIndex = 2;
            this.labelNumericGrade.Text = "Численная отметка";
            // 
            // labelStringGrade
            // 
            this.labelStringGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelStringGrade.Location = new System.Drawing.Point(2, 457);
            this.labelStringGrade.Name = "labelStringGrade";
            this.labelStringGrade.Size = new System.Drawing.Size(176, 100);
            this.labelStringGrade.TabIndex = 3;
            this.labelStringGrade.Text = "Строковая отметка";
            // 
            // labelStudentGPA
            // 
            this.labelStudentGPA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelStudentGPA.Location = new System.Drawing.Point(2, 344);
            this.labelStudentGPA.Name = "labelStudentGPA";
            this.labelStudentGPA.Size = new System.Drawing.Size(83, 100);
            this.labelStudentGPA.TabIndex = 4;
            this.labelStudentGPA.Text = "Ср. балл";
            // 
            // FormAllSubjectsAllSemesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 588);
            this.Controls.Add(this.labelStudentGPA);
            this.Controls.Add(this.labelStringGrade);
            this.Controls.Add(this.labelNumericGrade);
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
        private System.Windows.Forms.Label labelNumericGrade;
        private System.Windows.Forms.Label labelStringGrade;
        private System.Windows.Forms.Label labelStudentGPA;
    }
}