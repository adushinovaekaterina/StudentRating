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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxCertainSemester = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.comboBoxCertainSemester.Location = new System.Drawing.Point(247, 94);
            this.comboBoxCertainSemester.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCertainSemester.Name = "comboBoxCertainSemester";
            this.comboBoxCertainSemester.Size = new System.Drawing.Size(200, 34);
            this.comboBoxCertainSemester.TabIndex = 0;
            this.comboBoxCertainSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxCertainSemester_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите семестр:";
            // 
            // dataGridViewCertainSemester
            // 
            this.dataGridViewCertainSemester.AllowUserToAddRows = false;
            this.dataGridViewCertainSemester.AllowUserToDeleteRows = false;
            this.dataGridViewCertainSemester.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCertainSemester.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCertainSemester.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCertainSemester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCertainSemester.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCertainSemester.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCertainSemester.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridViewCertainSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCertainSemester.DefaultCellStyle = dataGridViewCellStyle44;
            this.dataGridViewCertainSemester.Location = new System.Drawing.Point(41, 188);
            this.dataGridViewCertainSemester.Name = "dataGridViewCertainSemester";
            this.dataGridViewCertainSemester.ReadOnly = true;
            this.dataGridViewCertainSemester.RowHeadersWidth = 56;
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
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewCertainSemester;
        private System.Windows.Forms.Label labelStudentGPA;
        private System.Windows.Forms.Label labelStudentsGPA;
        private System.Windows.Forms.Label labelStudentsGPAValue;
        private System.Windows.Forms.Label labelStudentGPAValue;
    }
}