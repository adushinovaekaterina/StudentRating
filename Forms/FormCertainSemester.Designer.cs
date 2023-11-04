namespace StudentRating.Forms
{
    partial class FormCertainSemester
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxCertainSemester = new System.Windows.Forms.ComboBox();
            this.labelChooseSemester = new System.Windows.Forms.Label();
            this.dataGridViewCertainSemester = new System.Windows.Forms.DataGridView();
            this.labelStudentGPA = new System.Windows.Forms.Label();
            this.labelStudentsGPA = new System.Windows.Forms.Label();
            this.labelStudentsGPAValue = new System.Windows.Forms.Label();
            this.labelStudentGPAValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCertainSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCertainSemester
            // 
            this.comboBoxCertainSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCertainSemester.FormattingEnabled = true;
            this.comboBoxCertainSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxCertainSemester.Location = new System.Drawing.Point(241, 94);
            this.comboBoxCertainSemester.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCertainSemester.Name = "comboBoxCertainSemester";
            this.comboBoxCertainSemester.Size = new System.Drawing.Size(151, 34);
            this.comboBoxCertainSemester.TabIndex = 0;
            this.comboBoxCertainSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxCertainSemester_SelectedIndexChanged);
            // 
            // labelChooseSemester
            // 
            this.labelChooseSemester.AutoSize = true;
            this.labelChooseSemester.ForeColor = System.Drawing.Color.Black;
            this.labelChooseSemester.Location = new System.Drawing.Point(36, 97);
            this.labelChooseSemester.Name = "labelChooseSemester";
            this.labelChooseSemester.Size = new System.Drawing.Size(227, 26);
            this.labelChooseSemester.TabIndex = 1;
            this.labelChooseSemester.Text = "Выберите семестр:";
            // 
            // dataGridViewCertainSemester
            // 
            this.dataGridViewCertainSemester.AllowUserToAddRows = false;
            this.dataGridViewCertainSemester.AllowUserToDeleteRows = false;
            this.dataGridViewCertainSemester.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCertainSemester.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCertainSemester.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCertainSemester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCertainSemester.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCertainSemester.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCertainSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCertainSemester.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCertainSemester.EnableHeadersVisualStyles = false;
            this.dataGridViewCertainSemester.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridViewCertainSemester.Location = new System.Drawing.Point(41, 188);
            this.dataGridViewCertainSemester.Name = "dataGridViewCertainSemester";
            this.dataGridViewCertainSemester.ReadOnly = true;
            this.dataGridViewCertainSemester.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCertainSemester.RowHeadersVisible = false;
            this.dataGridViewCertainSemester.RowHeadersWidth = 56;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCertainSemester.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCertainSemester.Size = new System.Drawing.Size(1093, 665);
            this.dataGridViewCertainSemester.TabIndex = 2;
            // 
            // labelStudentGPA
            // 
            this.labelStudentGPA.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentGPA.ForeColor = System.Drawing.Color.Black;
            this.labelStudentGPA.Location = new System.Drawing.Point(793, 148);
            this.labelStudentGPA.Name = "labelStudentGPA";
            this.labelStudentGPA.Size = new System.Drawing.Size(224, 27);
            this.labelStudentGPA.TabIndex = 7;
            this.labelStudentGPA.Text = "Мой средний балл: ";
            // 
            // labelStudentsGPA
            // 
            this.labelStudentsGPA.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentsGPA.ForeColor = System.Drawing.Color.Black;
            this.labelStudentsGPA.Location = new System.Drawing.Point(36, 148);
            this.labelStudentsGPA.Name = "labelStudentsGPA";
            this.labelStudentsGPA.Size = new System.Drawing.Size(392, 27);
            this.labelStudentsGPA.TabIndex = 6;
            this.labelStudentsGPA.Text = "Средний балл студентов в группе ";
            // 
            // labelStudentsGPAValue
            // 
            this.labelStudentsGPAValue.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentsGPAValue.ForeColor = System.Drawing.Color.Black;
            this.labelStudentsGPAValue.Location = new System.Drawing.Point(336, 148);
            this.labelStudentsGPAValue.Name = "labelStudentsGPAValue";
            this.labelStudentsGPAValue.Size = new System.Drawing.Size(311, 27);
            this.labelStudentsGPAValue.TabIndex = 8;
            // 
            // labelStudentGPAValue
            // 
            this.labelStudentGPAValue.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentGPAValue.ForeColor = System.Drawing.Color.Black;
            this.labelStudentGPAValue.Location = new System.Drawing.Point(965, 148);
            this.labelStudentGPAValue.Name = "labelStudentGPAValue";
            this.labelStudentGPAValue.Size = new System.Drawing.Size(202, 27);
            this.labelStudentGPAValue.TabIndex = 9;
            // 
            // FormCertainSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.labelStudentGPAValue);
            this.Controls.Add(this.labelStudentsGPAValue);
            this.Controls.Add(this.labelStudentGPA);
            this.Controls.Add(this.labelStudentsGPA);
            this.Controls.Add(this.dataGridViewCertainSemester);
            this.Controls.Add(this.labelChooseSemester);
            this.Controls.Add(this.comboBoxCertainSemester);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCertainSemester";
            this.Text = "ЖУРНАЛ РЕЙТИНГА ЗА ОПРЕДЕЛЕННЫЙ СЕМЕСТР";
            this.Load += new System.EventHandler(this.FormCertainSemester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCertainSemester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCertainSemester;
        private System.Windows.Forms.Label labelChooseSemester;
        public System.Windows.Forms.DataGridView dataGridViewCertainSemester;
        private System.Windows.Forms.Label labelStudentGPA;
        private System.Windows.Forms.Label labelStudentsGPA;
        private System.Windows.Forms.Label labelStudentsGPAValue;
        private System.Windows.Forms.Label labelStudentGPAValue;
    }
}