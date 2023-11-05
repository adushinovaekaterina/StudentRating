using StudentRating.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StudentRating.Forms
{
    public partial class FormCertainSubject : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        public int studentId;
        public int groupId;
        public FormCertainSubject(int studentId, int groupId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.groupId = groupId;
        }

        private void FormCertainSubject_Load(object sender, EventArgs e)
        {
            dataBaseConnection.OpenConnection();

            CreateColumns();            

            // -- получаем список предметов для вывода в comboBoxCertainSubject
            string queryStringGetSubjectsName = "SELECT subject_name FROM Subjects";
            SqlCommand sqlCommandGetSubjectsName = new SqlCommand(queryStringGetSubjectsName, dataBaseConnection.GetConnection());
            SqlDataReader readerGetSubjectsName = sqlCommandGetSubjectsName.ExecuteReader();
            while (readerGetSubjectsName.Read())
            {
                comboBoxCertainSubject.Items.Add(readerGetSubjectsName.GetString(0));
            }
            readerGetSubjectsName.Close();
            comboBoxCertainSubject.Text = comboBoxCertainSubject.Items[0].ToString();
        }
        // ПРЕДМЕТЫ
        private void comboBoxCertainSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewCertainSubject.Rows.Clear();
            labelStudentsGPAValue.Text = null;
            comboBoxCertainSemester.Items.Clear();

            // -- получаем семестры, в которых есть выбранный предмет
            string queryStringGetSemestersForSubject = $"SELECT DISTINCT Semesters.semester_number FROM Performance INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}'";
            SqlCommand sqlCommandGetSemestersForSubject = new SqlCommand(queryStringGetSemestersForSubject, dataBaseConnection.GetConnection());
            SqlDataReader readerGetSemestersForSubject = sqlCommandGetSemestersForSubject.ExecuteReader();

            while (readerGetSemestersForSubject.Read())
            {
                comboBoxCertainSemester.Items.Add(readerGetSemestersForSubject.GetByte(0));
            }
            readerGetSemestersForSubject.Close();
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
            dataGridViewCertainSubject.Columns.Add("grade_value", "Оценка");
        }
        // заполнение DataGridView
        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            string studentFIO = record.IsDBNull(0) ? "-" : record.GetString(0);
            string studentGradeValue = record.IsDBNull(1) ? "-" : record.GetString(1);

            dataGridView.Rows.Add(studentFIO, studentGradeValue);
        }
        private void RefreshDataGridView(DataGridView dataGridView)
        {
            if (comboBoxCertainSemester.SelectedItem != null)
            {
                int semesterNumber = int.Parse(comboBoxCertainSemester.SelectedItem.ToString());

                // -- получаем успеваемость для студента, вошедшего в систему -- // 
                //string queryStringGetPerformanceByStudentId = $"SELECT CASE WHEN Students.student_id = '{studentId}' THEN CONCAT(Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym) ELSE '-' END AS 'Студент', B.grade_value AS 'Отметка', COALESCE(A.typeOfCertification_name, B.typeOfCertification_name) AS 'Вид аттестации' FROM Students JOIN Groups ON Students.group_id = Groups.group_id LEFT JOIN (SELECT Performance.student_id, Types_Of_Certification.typeOfCertification_name FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Performance.student_id, Types_Of_Certification.typeOfCertification_name) AS A ON Students.student_id = A.student_id LEFT JOIN (SELECT Performance.student_id, Grades.grade_value, Types_Of_Certification.typeOfCertification_name FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Performance.student_id, Grades.grade_value, Types_Of_Certification.typeOfCertification_name) AS B ON Students.student_id = B.student_id WHERE Groups.group_id = '{groupId}' GROUP BY Students.student_id, Students.student_name, Students.student_surname, Students.student_patronym, B.grade_value, A.typeOfCertification_name, B.typeOfCertification_name ORDER BY CASE WHEN B.grade_value = N'зачтено' THEN 1 WHEN B.grade_value = '5' THEN 2 WHEN B.grade_value = '4' THEN 3 WHEN B.grade_value = '3' THEN 4 WHEN B.grade_value = N'не зачтено' THEN 5 ELSE 6 END;";
                string queryStringGetPerformanceByStudentId = $"SELECT CASE WHEN Students.student_id = '{studentId}' THEN CONCAT(Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym) ELSE '-' END AS 'Студент', B.grade_value AS 'Отметка' FROM Students INNER JOIN Groups ON Students.group_id = Groups.group_id LEFT JOIN (SELECT Performance.student_id FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Performance.student_id) AS A ON Students.student_id = A.student_id LEFT JOIN (SELECT Performance.student_id, Grades.grade_value FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Performance.student_id, Grades.grade_value) AS B ON Students.student_id = B.student_id WHERE Groups.group_id = '{groupId}' GROUP BY Students.student_id, Students.student_name, Students.student_surname, Students.student_patronym, B.grade_value ORDER BY CASE WHEN B.grade_value = N'зачтено' THEN 1 WHEN B.grade_value = '5' THEN 2 WHEN B.grade_value = '4' THEN 3 WHEN B.grade_value = '3' THEN 4 WHEN B.grade_value = N'не зачтено' THEN 5 ELSE 6 END;";
                SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, dataBaseConnection.GetConnection());
                SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

                while (readerGetPerformance.Read())
                {
                    ReadSingleRow(dataGridView, readerGetPerformance); // выводим успеваемость в DataGridView
                }
                readerGetPerformance.Close();

                List<string> listNumericOrStringGrades = new List<string>(); // список отметок в изначальном строковом формате
                List<float> listNumericGrades = new List<float>(); // список числовых отметок
                float studentsGPA = -1; // средний балл отметок студентов
                string groupName = ""; // название группы студента, зашедшего в систему

                // -- получаем все отметки студентОВ из группы студента, зашедшего в систему          
                string queryStringGetStudentsGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Groups.group_id = '{groupId}' AND Semesters.semester_number = '{semesterNumber}'";
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
                if (listNumericGrades.Count != 0)
                {
                    // высчитываем средний балл всех студентов группы по всем предметам за все семестры
                    studentsGPA = (float)Math.Round(listNumericGrades.Sum() / listNumericGrades.Count(), 1);
                }
                // получаем название группы студента, вошедшего в систему
                string queryStringGetGroupName = $"SELECT Groups.group_name FROM Groups WHERE Groups.group_id = '{groupId}'";
                SqlCommand sqlCommandGetGroupName = new SqlCommand(queryStringGetGroupName, dataBaseConnection.GetConnection());
                SqlDataReader readerGetGroupName = sqlCommandGetGroupName.ExecuteReader();
                while (readerGetGroupName.Read())
                {
                    groupName = readerGetGroupName.GetString(0);
                }
                readerGetGroupName.Close();

                string queryStringGetTypeOfCertification = $"SELECT DISTINCT Types_Of_Certification.typeOfCertification_name FROM Performance INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}' AND Semesters.semester_number = '{semesterNumber}'";
                SqlCommand sqlCommandGetTypeOfCertification = new SqlCommand(queryStringGetTypeOfCertification, dataBaseConnection.GetConnection());
                SqlDataReader readerGetTypeOfCertification = sqlCommandGetTypeOfCertification.ExecuteReader();

                while (readerGetTypeOfCertification.Read())
                {
                    labelTypeOfCertificationValue.Text += readerGetTypeOfCertification.GetString(0);
                }
                readerGetTypeOfCertification.Close();


                if (studentsGPA != -1)
                {
                    labelStudentsGPAValue.Text += groupName + ":  " + studentsGPA.ToString();
                }
                else
                {
                    labelStudentsGPAValue.Text += groupName + ":  -";
                }
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