using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace StudentRating.Forms
{
    public partial class AllSubjectsAllSemesters : Form
    {
        private int studentId;
        private int groupId;

        public AllSubjectsAllSemesters(int studentId, int groupId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.groupId = groupId;
        }
        private void FormAllSubjectsAllSemesters_Load(object sender, EventArgs e)
        {
            CreateColumns();
            if (dataGridViewAllSubjectsAllSemesters.Columns.Count == 6)
            {
                dataGridViewAllSubjectsAllSemesters.Columns.RemoveAt(0);
            }
            RefreshDataGridView(dataGridViewAllSubjectsAllSemesters);
            dataGridViewAllSubjectsAllSemesters.ClearSelection(); // убираем выделение первой левой ячейки
            SetDataGridViewHeight(dataGridViewAllSubjectsAllSemesters);

        }
        // создание столбцов в DataGridView
        private void CreateColumns()
        {
            dataGridViewAllSubjectsAllSemesters.Columns.Add("subject_name", "Предмет");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("grade_value", "Моя отметка");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("grade_value", "Средний балл в группе");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("typeOfCertification_name", "Вид аттестации");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("semester_number", "Семестр");
        }
        private void RefreshDataGridView(DataGridView dataGridView)
        {
            // заполнение dataGridView
            ControllerAllSubjectsAllSemesters.GetPerformanceForStudent(studentId, groupId, dataGridView);

            // вывод среднего балла группы
            string groupName = ControllerAllSubjectsAllSemesters.GetGroupName(groupId);
            float groupGPA = ControllerAllSubjectsAllSemesters.GetGroupGPA(groupId);

            // вывод среднего балла студента
            float studentGPA =  ControllerAllSubjectsAllSemesters.GetStudentGPA(studentId);

            if (groupGPA != -1)
            {
                labelStudentsGPA.Text += groupName + ":  " + groupGPA.ToString();
            }
            else
            {
                labelStudentsGPA.Text += groupName + ":  -";
            }

            if (studentGPA != -1)
            {
                labelStudentGPA.Text += studentGPA.ToString(); // выводим средний балл в соответствующий лейбл
            }
            else
            {
                labelStudentGPA.Text += "-";
            }

            dataGridViewAllSubjectsAllSemesters.Sort(dataGridViewAllSubjectsAllSemesters.Columns[4], ListSortDirection.Ascending);
            dataGridViewAllSubjectsAllSemesters.Columns.Insert(0, new DataGridViewTextBoxColumn()
            {
                Name = "Number",
                HeaderText = "Номер строки"
            });
            for (int i = 0; i < dataGridViewAllSubjectsAllSemesters.Rows.Count; i++)
            {
                dataGridViewAllSubjectsAllSemesters.Rows[i].Cells["Number"].Value = i + 1;
                dataGridViewAllSubjectsAllSemesters.Columns[0].Width = 100;
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