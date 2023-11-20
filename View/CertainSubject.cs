using StudentRating.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentRating.Forms
{
    public partial class CertainSubject : Form
    {
        DataBase dataBaseConnection = new DataBase();
        private int studentId;
        private int groupId;
        public CertainSubject(int studentId, int groupId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.groupId = groupId;
        }

        private void FormCertainSubject_Load(object sender, EventArgs e)
        {
            CreateColumns();
            ControllerCertainSubject.GetSubjects(comboBoxCertainSubject);
            comboBoxCertainSubject.Text = comboBoxCertainSubject.Items[0].ToString();
        }
        // ПРЕДМЕТЫ
        private void comboBoxCertainSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewCertainSubject.Rows.Clear();
            labelStudentsGPAValue.Text = null;
            comboBoxCertainSemester.Items.Clear();

            string subjectName = comboBoxCertainSubject.Text;
            ControllerCertainSubject.GetSemesters(subjectName, comboBoxCertainSemester);
            try
            {
                comboBoxCertainSemester.Text = comboBoxCertainSemester.Items[0].ToString();
            }
            catch { }
        }
        // СЕМЕСТРЫ
        private void comboBoxCertainSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewCertainSubject.Rows.Clear();
            labelStudentsGPAValue.Text = null;
            labelTypeOfCertificationValue.Text = null;
            if (dataGridViewCertainSubject.Columns.Count == 3)
            {
                dataGridViewCertainSubject.Columns.RemoveAt(0);
            }
            RefreshDataGridView(dataGridViewCertainSubject);
            dataGridViewCertainSubject.ClearSelection(); // убираем выделение первой левой ячейки
            SetDataGridViewHeight(dataGridViewCertainSubject);
        }
        // создание столбцов в DataGridView
        private void CreateColumns()
        {
            dataGridViewCertainSubject.Columns.Add("student_FIO", "Студент");
            dataGridViewCertainSubject.Columns.Add("grade_value", "Отметка");
        }        
        private void RefreshDataGridView(DataGridView dataGridView)
        {
            if (comboBoxCertainSemester.SelectedItem != null)
            {
                int semesterNumber = int.Parse(comboBoxCertainSemester.SelectedItem.ToString());
                string subjectName = comboBoxCertainSubject.Text;

                // заполнение dataGridView
                ControllerCertainSubject.GetPerformanceForStudent(studentId, groupId, dataGridView, subjectName, semesterNumber);

                // расчет среднего балла группы
                string groupName = ControllerCertainSubject.GetGroupName(groupId);
                float groupGPA = ControllerCertainSubject.GetGroupGPA(groupId, subjectName, semesterNumber);

                if (groupGPA != -1)
                {
                    labelStudentsGPAValue.Text += groupName + ":  " + groupGPA.ToString();
                }
                else
                {
                    labelStudentsGPAValue.Text += groupName + ":  -";
                }

                labelTypeOfCertificationValue.Text += ControllerCertainSubject.GetTypeOfCertification(subjectName, semesterNumber);

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "-")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    }                    
                }
                for (int rowIndex = 0; rowIndex < dataGridViewCertainSubject.Rows.Count; rowIndex++)
                {
                    var row = dataGridViewCertainSubject.Rows[rowIndex];

                    for (int columnIndex = 0; columnIndex < row.Cells.Count; columnIndex++)
                    {
                        if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString() == "не зачтено")
                        {
                            row.Cells[columnIndex].Style.ForeColor = Color.Red;
                        }
                    }
                }
            }
            dataGridViewCertainSubject.Columns.Insert(0, new DataGridViewTextBoxColumn()
            {
                Name = "Number",
                HeaderText = "Номер строки"
            });
            for (int i = 0; i < dataGridViewCertainSubject.Rows.Count; i++)
            {
                dataGridViewCertainSubject.Rows[i].Cells["Number"].Value = i + 1;
                dataGridViewCertainSubject.Columns[0].Width = 100;
            }
            int columnInd = 2;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnInd].Value == null)
                    continue;

                string cellValue = row.Cells[columnInd].Value.ToString();

                if (cellValue == "-" || cellValue == "3" || cellValue == "не зачтено")
                {
                    row.Cells[columnInd].Style.ForeColor = Color.Red;
                }
            }
        }
        private void SetDataGridViewHeight(DataGridView dataGridView)
        {
            int totalHeight = 0;

            // Суммируем высоту каждой строки
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                totalHeight += row.Height;
            }

            // Добавляем высоту заголовка DataGridView
            totalHeight += dataGridView.ColumnHeadersHeight;

            // Устанавливаем высоту DataGridView
            dataGridView.Height = totalHeight;
        }
    }
}