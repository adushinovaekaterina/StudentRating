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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxCertainSemester = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCertainSemester = new System.Windows.Forms.DataGridView();
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
            this.comboBoxCertainSemester.Location = new System.Drawing.Point(346, 92);
            this.comboBoxCertainSemester.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCertainSemester.Name = "comboBoxCertainSemester";
            this.comboBoxCertainSemester.Size = new System.Drawing.Size(200, 28);
            this.comboBoxCertainSemester.TabIndex = 0;
            this.comboBoxCertainSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxCertainSemester_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(143, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCertainSemester.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCertainSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCertainSemester.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCertainSemester.Location = new System.Drawing.Point(147, 140);
            this.dataGridViewCertainSemester.Name = "dataGridViewCertainSemester";
            this.dataGridViewCertainSemester.ReadOnly = true;
            this.dataGridViewCertainSemester.Size = new System.Drawing.Size(785, 545);
            this.dataGridViewCertainSemester.TabIndex = 2;
            // 
            // FormCertainSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.dataGridViewCertainSemester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCertainSemester);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCertainSemester";
            this.Text = "ЖУРНАЛ РЕЙТИНГА ЗА ОПРЕДЕЛЕННЫЙ СЕМЕСТР";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCertainSemester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCertainSemester;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewCertainSemester;
    }
}