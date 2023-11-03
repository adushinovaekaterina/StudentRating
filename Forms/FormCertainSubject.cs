using StudentRating.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            RefreshDataGridView(dataGridViewCertainSemester);
            dataGridViewCertainSemester.ClearSelection(); // убираем выделение первой левой ячейки

            // -- получаем список предметов для вывода в comboBoxCertainSubject
            string queryStringGetSubjectsName = $"SELECT subject_name FROM Subjects";
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
            dataGridViewCertainSemester.Rows.Clear();
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
            dataGridViewCertainSemester.Rows.Clear();
            labelStudentsGPAValue.Text = null;
            RefreshDataGridView(dataGridViewCertainSemester);
        }
        // создание столбцов в DataGridView
        private void CreateColumns()
        {
            dataGridViewCertainSemester.Columns.Add("student_FIO", "Студент");
            dataGridViewCertainSemester.Columns.Add("grade_value", "Оценка");
            dataGridViewCertainSemester.Columns.Add("typeOfCertification_name", "Вид аттестации");
        }

        // заполнение DataGridView
        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            string studentFIO = record.IsDBNull(0) ? "-" : record.GetString(0);
            string studentGradeValue = record.IsDBNull(1) ? "-" : record.GetString(1);
            string typeOfCertification = record.IsDBNull(2) ? "-" : record.GetString(2);

            dataGridView.Rows.Add(studentFIO, studentGradeValue, typeOfCertification);
        }
        private void RefreshDataGridView(DataGridView dataGridView)
        {
            if (comboBoxCertainSemester.SelectedItem != null)
            {
                int semesterNumber = int.Parse(comboBoxCertainSemester.SelectedItem.ToString());


                // -- получаем успеваемость для студента, вошедшего в систему -- // 
                string queryStringGetPerformanceByStudentId = $"SELECT CASE WHEN Students.student_id = '{studentId}' THEN CONCAT(Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym) ELSE '-' END AS 'Студент', Grades.grade_value AS 'Оценка', Types_Of_Certification.typeOfCertification_name AS 'Вид аттестации' FROM Performance INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}' AND Semesters.semester_number = '{semesterNumber}' ORDER BY CASE WHEN Students.student_id = 1 THEN 1 ELSE 2 END";
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
                if (studentsGPA != -1)
                {
                    labelStudentsGPAValue.Text += groupName + ":  " + studentsGPA.ToString();
                }
                else
                {
                    labelStudentsGPAValue.Text += groupName + ":  -";
                }


                //comboBoxCertainSemester.Text = comboBoxCertainSubject.Items[0].ToString();
            }
        }

        private void labelStudentsGPA_Click(object sender, EventArgs e)
        {

        }

       
    }
}
