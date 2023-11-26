using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StudentRating.Forms
{
    public partial class CertainSemester : Form
    {
        private int studentId;
        private int groupId;
        public CertainSemester(int studentId, int groupId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.groupId = groupId;
        }

        private void FormCertainSemester_Load(object sender, EventArgs e)
        {
            CreateColumns();            
            comboBoxCertainSemester.Text = comboBoxCertainSemester.Items[0].ToString();
        }
        private void comboBoxCertainSemester_SelectedIndexChanged(object sender, EventArgs e)
        {            
            dataGridViewCertainSemester.Rows.Clear();
            labelStudentGPAValue.Text = null;
            labelStudentsGPAValue.Text= null;
            if (dataGridViewCertainSemester.Columns.Count == 5)
            {
                dataGridViewCertainSemester.Columns.RemoveAt(0);
            }            
            RefreshDataGridView(dataGridViewCertainSemester);
            dataGridViewCertainSemester.ClearSelection(); // убираем выделение первой левой ячейки
            SetDataGridViewHeight(dataGridViewCertainSemester);            
        }
        // создание столбцов в DataGridView
        private void CreateColumns()
        {
            dataGridViewCertainSemester.Columns.Add("subject_name", "Предмет");
            dataGridViewCertainSemester.Columns.Add("grade_value", "Моя отметка");
            dataGridViewCertainSemester.Columns.Add("grade_value", "Средний балл в группе");
            dataGridViewCertainSemester.Columns.Add("typeOfCertification_name", "Вид аттестации");
        }
        private void RefreshDataGridView(DataGridView dataGridView)
        {
            int semesterNumber = int.Parse(comboBoxCertainSemester.SelectedItem.ToString());
            // заполнение dataGridView
            ControllerCertainSemester.GetPerformanceForStudent(studentId, groupId, dataGridView, semesterNumber);

            // расчет среднего балла группы
            string groupName = ControllerCertainSemester.GetGroupName(groupId);
            float groupGPA = ControllerCertainSemester.CalculationGroupGPA(groupId, semesterNumber);

            // расчет среднего балла студента
            float studentGPA = ControllerCertainSemester.CalculationStudentGPA(studentId, semesterNumber);

            if (groupGPA != -1)
            {
                labelStudentsGPAValue.Text += groupName + ":  " + groupGPA.ToString();
            }
            else
            {
                labelStudentsGPAValue.Text += groupName + ":  -";
            }

            if (studentGPA != -1)
            {
                labelStudentGPAValue.Text += studentGPA.ToString(); // выводим средний балл в соответствующий лейбл
            }
            else
            {
                labelStudentGPAValue.Text += "-";
            }
            dataGridViewCertainSemester.Sort(dataGridViewCertainSemester.Columns[1], ListSortDirection.Descending);
            dataGridViewCertainSemester.Columns.Insert(0, new DataGridViewTextBoxColumn()
            {
                Name = "Number",
                HeaderText = "Номер строки"
            });
            for (int i = 0; i < dataGridViewCertainSemester.Rows.Count; i++)
            {
                dataGridViewCertainSemester.Rows[i].Cells["Number"].Value = i + 1;
                dataGridViewCertainSemester.Columns[0].Width = 100;
            }
            int columnIndex = 2;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value == null)
                    continue;

                string cellValue = row.Cells[columnIndex].Value.ToString();

                if (cellValue == "-" || cellValue == "3" || cellValue == "не зачтено")
                {
                    row.Cells[columnIndex].Style.ForeColor = Color.Red;
                }
            }
            columnIndex = 3;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value == null)
                    continue;

                string cellValue = row.Cells[columnIndex].Value.ToString();

                bool isInRange = false;
                if (decimal.TryParse(cellValue, out decimal value))
                {
                    if (value >= 3.0m && value <= 3.9m)
                        isInRange = true;
                }
                if (isInRange)
                {
                    row.Cells[columnIndex].Style.ForeColor = Color.Red;
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