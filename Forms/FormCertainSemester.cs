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
    public partial class FormCertainSemester : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        public int studentId;
        public int groupId;
        public FormCertainSemester(int studentId, int groupId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.groupId = groupId;
        }

        private void FormCertainSemester_Load(object sender, EventArgs e)
        {
            dataBaseConnection.OpenConnection();

            CreateColumns();
            RefreshDataGridView(dataGridViewCertainSemester);
            dataGridViewCertainSemester.ClearSelection(); // убираем выделение первой левой ячейки
            comboBoxCertainSemester.Text = comboBoxCertainSemester.Items[0].ToString();
        }
        private void comboBoxCertainSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewCertainSemester.Rows.Clear();
            labelStudentGPAValue.Text = null;
            labelStudentsGPAValue.Text= null;
            RefreshDataGridView(dataGridViewCertainSemester);
        }
        // создание столбцов в DataGridView
        private void CreateColumns()
        {
            dataGridViewCertainSemester.Columns.Add("subject_name", "Предмет");
            dataGridViewCertainSemester.Columns.Add("grade_value", "Моя отметка");
            dataGridViewCertainSemester.Columns.Add("grade_value", "Средний балл в группе");
            dataGridViewCertainSemester.Columns.Add("typeOfCertification_name", "Вид аттестации");
        }

        // заполнение DataGridView
        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            string subjectName = record.IsDBNull(0) ? "-" : record.GetString(0);
            string studentGradeValue = record.IsDBNull(1) ? "-" : record.GetString(1);
            object averageGrade = IsNullOrDecimal(record, 2);
            string typeOfCertification = record.IsDBNull(3) ? "-" : record.GetString(3);
            byte semester = (byte)(record.IsDBNull(4) ? 0 : record.GetByte(4));

            dataGridView.Rows.Add(subjectName, studentGradeValue, averageGrade, typeOfCertification, semester);
        }
        private object IsNullOrDecimal(IDataRecord record, int i)
        {
            if (record.IsDBNull(i))
            {
                return "-";
            }
            else
            {
                return record.GetDecimal(i);
            }
        }
        private void RefreshDataGridView(DataGridView dataGridView)
        {
            string semesterNumber = comboBoxCertainSemester.Text;
            // -- получаем успеваемость для студента, вошедшего в систему -- // 
            string queryStringGetPerformanceByStudentId = $"SELECT A.subject_name AS 'Предмет', B.grade_value AS 'Моя отметка', AVG(A.grade_value) AS 'Средний балл в группе', A.typeOfCertification_name AS 'Вид аттестации', A.semester_number AS 'Семестр' FROM (SELECT Subjects.subject_name, ROUND(AVG(CASE WHEN ISNUMERIC(Grades.grade_value) = 1 THEN CAST(Grades.grade_value AS decimal) END), 3) AS grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Subjects.subject_name, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number) AS A LEFT JOIN (SELECT Subjects.subject_name, Grades.grade_value FROM Subjects INNER JOIN Performance ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}' AND Students.student_id = '{studentId}' GROUP BY Subjects.subject_name, Grades.grade_value, Students.student_name) AS B ON A.subject_name = B.subject_name GROUP BY A.subject_name, A.typeOfCertification_name, A.semester_number, B.grade_value";
            SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, dataBaseConnection.GetConnection());
            SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

            while (readerGetPerformance.Read())
            {
                ReadSingleRow(dataGridView, readerGetPerformance); // выводим успеваемость в DataGridView
            }
            readerGetPerformance.Close();

            List<string> listNumericOrStringGrades = new List<string>(); // список отметок в изначальном строковом формате
            List<float> listNumericGrades = new List<float>(); // список числовых отметок
            float studentsGPA = 0; // средний балл отметок студентов
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
            if (studentsGPA == float.NaN)
            {
                labelStudentsGPAValue.Text += "-";
            }
            else
            {
                labelStudentsGPAValue.Text += groupName + ":  " + studentsGPA.ToString();
            }


            List<string> listNumericOrStringGradesForOneStudent = new List<string>(); // список отметок в изначальном строковом формате
            List<float> listNumericGradesForOneStudent = new List<float>(); // список числовых отметок
            float studentGPA = 0; // средний балл отметок студентов

            // -- получаем все отметки студентА, зашедшего в систему          
            string queryStringGetStudentGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Students.student_id = '{studentId}' AND Semesters.semester_number = '{semesterNumber}'";
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
            labelStudentGPAValue.Text += studentGPA.ToString(); // выводим средний балл в соответствующий лейбл
        }
    }
}
