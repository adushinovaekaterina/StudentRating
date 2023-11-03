namespace StudentRating.Forms
{
    partial class FormCertainSubject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelChooseSubject = new System.Windows.Forms.Label();
            this.comboBoxCertainSubject = new System.Windows.Forms.ComboBox();
            this.dataGridViewCertainSemester = new System.Windows.Forms.DataGridView();
            this.labelStudentsGPAValue = new System.Windows.Forms.Label();
            this.labelStudentsGPA = new System.Windows.Forms.Label();
            this.comboBoxCertainSemester = new System.Windows.Forms.ComboBox();
            this.labelChooseSemester = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCertainSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseSubject
            // 
            this.labelChooseSubject.AutoSize = true;
            this.labelChooseSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelChooseSubject.ForeColor = System.Drawing.Color.Black;
            this.labelChooseSubject.Location = new System.Drawing.Point(36, 97);
            this.labelChooseSubject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelChooseSubject.Name = "labelChooseSubject";
            this.labelChooseSubject.Size = new System.Drawing.Size(230, 26);
            this.labelChooseSubject.TabIndex = 2;
            this.labelChooseSubject.Text = "Выберите предмет:";
            // 
            // comboBoxCertainSubject
            // 
            this.comboBoxCertainSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCertainSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCertainSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxCertainSubject.FormattingEnabled = true;
            this.comboBoxCertainSubject.Location = new System.Drawing.Point(241, 94);
            this.comboBoxCertainSubject.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.comboBoxCertainSubject.Name = "comboBoxCertainSubject";
            this.comboBoxCertainSubject.Size = new System.Drawing.Size(449, 34);
            this.comboBoxCertainSubject.TabIndex = 11;
            this.comboBoxCertainSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxCertainSubject_SelectedIndexChanged);
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCertainSemester.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewCertainSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCertainSemester.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewCertainSemester.Location = new System.Drawing.Point(41, 188);
            this.dataGridViewCertainSemester.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewCertainSemester.Name = "dataGridViewCertainSemester";
            this.dataGridViewCertainSemester.ReadOnly = true;
            this.dataGridViewCertainSemester.RowHeadersWidth = 56;
            this.dataGridViewCertainSemester.Size = new System.Drawing.Size(1093, 665);
            this.dataGridViewCertainSemester.TabIndex = 12;
            // 
            // labelStudentsGPAValue
            // 
            this.labelStudentsGPAValue.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentsGPAValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelStudentsGPAValue.ForeColor = System.Drawing.Color.Black;
            this.labelStudentsGPAValue.Location = new System.Drawing.Point(336, 148);
            this.labelStudentsGPAValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStudentsGPAValue.Name = "labelStudentsGPAValue";
            this.labelStudentsGPAValue.Size = new System.Drawing.Size(392, 27);
            this.labelStudentsGPAValue.TabIndex = 14;
            // 
            // labelStudentsGPA
            // 
            this.labelStudentsGPA.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentsGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelStudentsGPA.ForeColor = System.Drawing.Color.Black;
            this.labelStudentsGPA.Location = new System.Drawing.Point(36, 148);
            this.labelStudentsGPA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStudentsGPA.Name = "labelStudentsGPA";
            this.labelStudentsGPA.Size = new System.Drawing.Size(392, 27);
            this.labelStudentsGPA.TabIndex = 13;
            this.labelStudentsGPA.Text = "Средний балл студентов в группе ";
            this.labelStudentsGPA.Click += new System.EventHandler(this.labelStudentsGPA_Click);
            // 
            // comboBoxCertainSemester
            // 
            this.comboBoxCertainSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCertainSemester.FormattingEnabled = true;
            this.comboBoxCertainSemester.Location = new System.Drawing.Point(940, 94);
            this.comboBoxCertainSemester.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCertainSemester.Name = "comboBoxCertainSemester";
            this.comboBoxCertainSemester.Size = new System.Drawing.Size(151, 34);
            this.comboBoxCertainSemester.TabIndex = 15;
            this.comboBoxCertainSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxCertainSemester_SelectedIndexChanged);
            // 
            // labelChooseSemester
            // 
            this.labelChooseSemester.AutoSize = true;
            this.labelChooseSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelChooseSemester.ForeColor = System.Drawing.Color.Black;
            this.labelChooseSemester.Location = new System.Drawing.Point(744, 97);
            this.labelChooseSemester.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelChooseSemester.Name = "labelChooseSemester";
            this.labelChooseSemester.Size = new System.Drawing.Size(227, 26);
            this.labelChooseSemester.TabIndex = 16;
            this.labelChooseSemester.Text = "Выберите семестр:";
            // 
            // FormCertainSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.labelChooseSemester);
            this.Controls.Add(this.comboBoxCertainSemester);
            this.Controls.Add(this.labelStudentsGPAValue);
            this.Controls.Add(this.labelStudentsGPA);
            this.Controls.Add(this.dataGridViewCertainSemester);
            this.Controls.Add(this.comboBoxCertainSubject);
            this.Controls.Add(this.labelChooseSubject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormCertainSubject";
            this.Text = "ЖУРНАЛ РЕЙТИНГА ПО ОПРЕДЕЛЕННОМУ ПРЕДМЕТУ";
            this.Load += new System.EventHandler(this.FormCertainSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCertainSemester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseSubject;
        private System.Windows.Forms.ComboBox comboBoxCertainSubject;
        public System.Windows.Forms.DataGridView dataGridViewCertainSemester;
        private System.Windows.Forms.Label labelStudentsGPAValue;
        private System.Windows.Forms.Label labelStudentsGPA;
        private System.Windows.Forms.ComboBox comboBoxCertainSemester;
        private System.Windows.Forms.Label labelChooseSemester;
    }
}