using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRating.Controller
{
    internal class Controller
    {
        private void RefreshDataGridView(DataGridView dataGridView)
        {
            List<string> listNumericOrStringGrades = new List<string>(); // список отметок в изначальном строковом формате
            List<float> listNumericGrades = new List<float>(); // список числовых отметок
            float studentsGPA = 0; // средний балл отметок студентов
            string groupName = ""; // название группы студента, зашедшего в систему

            // -- получаем все отметки студентОВ из группы студента, зашедшего в систему          
            string queryStringGetStudentsGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}'";
            SqlCommand sqlCommandGetStudentsGrades = new SqlCommand(queryStringGetStudentsGrades, dataBaseConnection.GetConnection());
            SqlDataReader readerGetStudentsGrades = sqlCommandGetStudentsGrades.ExecuteReader();
            while (readerGetStudentsGrades.Read())
            {
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGrades.Add(readerGetStudentsGrades.GetString(0));
            }
            readerGetStudentsGrades.Close();

            // выводим отметки в лейбл для числовых отметок и в лейбл для строковых         
            for (int i = 0; i < listNumericOrStringGrades.Count(); i++) // проходимся по всем отметкам в списке
            {
                int numericGrade; // конвертированная в численный тип отметка
                bool isNumber = int.TryParse(listNumericOrStringGrades[i], out numericGrade);
                if (isNumber) // если отметка числовая, то добавляем ее в список числовых отметок
                {
                    listNumericGrades.Add(numericGrade);
                }
            }
            // высчитываем средний балл всех студентов группы по всем предметам за все семестры
            studentsGPA = (float)Math.Round(listNumericGrades.Sum() / listNumericGrades.Count(), 1);

            // получаем название группы студента, вошедшего в систему
            string queryStringGetGroupName = $"SELECT Groups.group_name FROM Groups WHERE Groups.group_id = '{groupId}'";
            SqlCommand sqlCommandGetGroupName = new SqlCommand(queryStringGetGroupName, dataBaseConnection.GetConnection());
            SqlDataReader readerGetGroupName = sqlCommandGetGroupName.ExecuteReader();
            while (readerGetGroupName.Read())
            {
                groupName = readerGetGroupName.GetString(0);
            }
            readerGetGroupName.Close();

            labelStudentsGPA.Text += groupName + ":   " + studentsGPA.ToString(); // выводим средний балл в соответствующий лейбл



            List<string> listNumericOrStringGradesForOneStudent = new List<string>(); // список отметок в изначальном строковом формате
            List<float> listNumericGradesForOneStudent = new List<float>(); // список числовых отметок
            float studentGPA = 0; // средний балл отметок студентов

            // -- получаем все отметки студентА, зашедшего в систему          
            string queryStringGetStudentGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Students.student_id = '{studentId}'";
            SqlCommand sqlCommandGetStudentGrades = new SqlCommand(queryStringGetStudentGrades, dataBaseConnection.GetConnection());
            SqlDataReader readerGetStudentGrades = sqlCommandGetStudentGrades.ExecuteReader();
            while (readerGetStudentGrades.Read())
            {
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGradesForOneStudent.Add(readerGetStudentGrades.GetString(0));
            }
            readerGetStudentGrades.Close();

            // выводим отметки в лейбл для числовых отметок и в лейбл для строковых         
            for (int i = 0; i < listNumericOrStringGradesForOneStudent.Count(); i++) // проходимся по всем отметкам в списке
            {
                int numericGrade; // конвертированная в численный тип отметка
                bool isNumber = int.TryParse(listNumericOrStringGradesForOneStudent[i], out numericGrade);
                if (isNumber) // если отметка числовая, то добавляем ее в список числовых отметок
                {
                    listNumericGradesForOneStudent.Add(numericGrade);
                }
            }
            // высчитываем средний балл всех студентов группы по всем предметам за все семестры
            studentGPA = (float)Math.Round(listNumericGradesForOneStudent.Sum() / listNumericGradesForOneStudent.Count(), 1);
            labelStudentGPA.Text += studentGPA.ToString(); // выводим средний балл в соответствующий лейбл
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
