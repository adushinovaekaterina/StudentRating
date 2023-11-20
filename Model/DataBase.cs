using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentRating.Classes
{
    class DataBase
    {
        private SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDatabaseStudentRating"].ConnectionString);
        private int studentIdFromDataBase;
        private int groupIdFromDataBase;

        private void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        private void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        private SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        // Authorization
        public List<int> GetStudentIdGroupId(string login, string password)
        {
            OpenConnection();
            string querySelectStudent = $"SELECT student_id, student_login, student_password FROM Students WHERE student_login = '{login}' and student_password = '{password}'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(querySelectStudent, GetConnection());

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                // получаем studentId по логину пользователя для передачи studentId на другие формы
                string queryGetStudentIdByLogin = $"SELECT student_id FROM Students WHERE student_login = '{login}'";
                SqlCommand sqlCommandGetStudentIdByLogin = new SqlCommand(queryGetStudentIdByLogin, GetConnection());
                SqlDataReader readerGetStudentIdByLogin = sqlCommandGetStudentIdByLogin.ExecuteReader();
                while (readerGetStudentIdByLogin.Read())
                {
                    studentIdFromDataBase = readerGetStudentIdByLogin.GetInt32(0);
                }
                readerGetStudentIdByLogin.Close();

                // получаем groupId по studentId для передачи groupId на другие формы
                string queryGetGroupId = $"SELECT Groups.group_id FROM Students INNER JOIN Groups ON Students.group_id = Groups.group_id WHERE Students.student_id = '{studentIdFromDataBase}'";
                SqlCommand sqlCommandGetGroupId = new SqlCommand(queryGetGroupId, GetConnection());
                SqlDataReader readerGetGroupId = sqlCommandGetGroupId.ExecuteReader();
                while (readerGetGroupId.Read())
                {
                    groupIdFromDataBase = readerGetGroupId.GetInt32(0);
                }
                readerGetGroupId.Close();
                CloseConnection();
            }
            List<int> studentIdGroupIdList = new List<int>();
            studentIdGroupIdList.Add(studentIdFromDataBase);
            studentIdGroupIdList.Add(groupIdFromDataBase);
            return studentIdGroupIdList;
        }
        public string SetFIOForRatingJournal(string login, RatingJournal ratingJournal)
        {
            OpenConnection();
            string FIOstudent = "";
            // берем ФИО студента для отображения на лэйбле FormRatingJournal
            string querySelectStudentNameByLogin = $"SELECT CONCAT (Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym) FROM Students WHERE student_login = '{login}'";
            SqlCommand sqlCommandSelectStudentNameByLogin = new SqlCommand(querySelectStudentNameByLogin, GetConnection());
            SqlDataReader reader = sqlCommandSelectStudentNameByLogin.ExecuteReader();
            while (reader.Read())
            {
                FIOstudent = reader.GetString(0);
            }
            reader.Close();
            CloseConnection();
            return FIOstudent;
        }
        // AllSubjectAllSemesters
        private void ReadSingleRowForAllSubjectAllSemesters(DataGridView dataGridView, IDataRecord record)    // заполнение DataGridView
        {
            string subjectName = record.IsDBNull(0) ? "-" : record.GetString(0);
            string studentGradeValue = record.IsDBNull(1) ? "-" : record.GetString(1);
            object averageGrade = IsNullOrDecimalForAllSubjectAllSemesters(record, 2);
            string typeOfCertification = record.IsDBNull(3) ? "-" : record.GetString(3);
            byte semester = (byte)(record.IsDBNull(4) ? 0 : record.GetByte(4));

            dataGridView.Rows.Add(subjectName, studentGradeValue, averageGrade, typeOfCertification, semester);
        }
        private object IsNullOrDecimalForAllSubjectAllSemesters(IDataRecord record, int i)
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
        public void GetPerformanceForStudentForAllSubjectAllSemesters(int studentId, int groupId, DataGridView dataGridView)
        {
            OpenConnection();
            // -- получаем успеваемость для студента, вошедшего в систему -- // 
            string queryStringGetPerformanceByStudentId = $"SELECT A.subject_name AS 'Предмет', B.grade_value AS 'Моя отметка', AVG(A.grade_value) AS 'Средний балл в группе', A.typeOfCertification_name AS 'Вид аттестации', A.semester_number AS 'Семестр' FROM (SELECT Subjects.subject_name, ROUND(AVG(CASE WHEN ISNUMERIC(Grades.grade_value) = 1 THEN CAST(Grades.grade_value AS decimal) END), 3) AS grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}' GROUP BY Subjects.subject_name, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number) AS A LEFT JOIN (SELECT Subjects.subject_name, Grades.grade_value FROM Subjects INNER JOIN Performance ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}' AND Students.student_id = '{studentId}' GROUP BY Subjects.subject_name, Grades.grade_value, Students.student_name) AS B ON A.subject_name = B.subject_name GROUP BY A.subject_name, A.typeOfCertification_name, A.semester_number, B.grade_value";
            SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, GetConnection());
            SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

            while (readerGetPerformance.Read())
            {
                ReadSingleRowForAllSubjectAllSemesters(dataGridView, readerGetPerformance); // выводим успеваемость в DataGridView
            }
            readerGetPerformance.Close();
            CloseConnection();
        }
        public List<string> GetGroupGradesForAllSubjectAllSemesters(int groupId)
        {
            OpenConnection();
            List<string> listNumericOrStringGrades = new List<string>(); // список отметок в изначальном строковом формате

            // -- получаем все отметки студентОВ из группы студента, зашедшего в систему          
            string queryStringGetStudentsGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}'";
            SqlCommand sqlCommandGetStudentsGrades = new SqlCommand(queryStringGetStudentsGrades, GetConnection());
            SqlDataReader readerGetStudentsGrades = sqlCommandGetStudentsGrades.ExecuteReader();
            while (readerGetStudentsGrades.Read())
            {
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGrades.Add(readerGetStudentsGrades.GetString(0));
            }
            readerGetStudentsGrades.Close();
            CloseConnection();
            return listNumericOrStringGrades;
        }
        public string GetGroupName(int groupId)
        {
            OpenConnection();
            string groupName = ""; // название группы студента, зашедшего в систему   
            // получаем название группы студента, вошедшего в систему
            string queryStringGetGroupName = $"SELECT Groups.group_name FROM Groups WHERE Groups.group_id = '{groupId}'";
            SqlCommand sqlCommandGetGroupName = new SqlCommand(queryStringGetGroupName, GetConnection());
            SqlDataReader readerGetGroupName = sqlCommandGetGroupName.ExecuteReader();
            while (readerGetGroupName.Read())
            {
                groupName = readerGetGroupName.GetString(0);
            }
            readerGetGroupName.Close();
            CloseConnection();
            return groupName;
        }
        public List<string> GetStudentGradesForAllSubjectAllSemesters(int studentId)
        {
            OpenConnection();
            List<string> listNumericOrStringGradesForOneStudent = new List<string>(); // список отметок в изначальном строковом формате

            // -- получаем все отметки студентА, зашедшего в систему          
            string queryStringGetStudentGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Students.student_id = '{studentId}'";
            SqlCommand sqlCommandGetStudentGrades = new SqlCommand(queryStringGetStudentGrades, GetConnection());
            SqlDataReader readerGetStudentGrades = sqlCommandGetStudentGrades.ExecuteReader();
            while (readerGetStudentGrades.Read())
            {
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGradesForOneStudent.Add(readerGetStudentGrades.GetString(0));
            }
            readerGetStudentGrades.Close();
            CloseConnection();
            return listNumericOrStringGradesForOneStudent;
        }
        // CertainSemester
        // заполнение DataGridView
        private void ReadSingleRowForCertainSemester(DataGridView dataGridView, IDataRecord record)
        {
            string subjectName = record.IsDBNull(0) ? "-" : record.GetString(0);
            string studentGradeValue = record.IsDBNull(1) ? "-" : record.GetString(1);
            object averageGrade = IsNullOrDecimalForCertainSemester(record, 2);
            string typeOfCertification = record.IsDBNull(3) ? "-" : record.GetString(3);
            byte semester = (byte)(record.IsDBNull(4) ? 0 : record.GetByte(4));

            dataGridView.Rows.Add(subjectName, studentGradeValue, averageGrade, typeOfCertification, semester);
        }
        private object IsNullOrDecimalForCertainSemester(IDataRecord record, int i)
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
        public void GetPerformanceForStudentForCertainSemester(int studentId, int groupId, DataGridView dataGridView, int semesterNumber)
        {
            OpenConnection();
            // -- получаем успеваемость для студента, вошедшего в систему -- // 
            string queryStringGetPerformanceByStudentId = $"SELECT A.subject_name AS 'Предмет', B.grade_value AS 'Моя отметка', AVG(A.grade_value) AS 'Средний балл в группе', A.typeOfCertification_name AS 'Вид аттестации', A.semester_number AS 'Семестр' FROM (SELECT Subjects.subject_name, ROUND(AVG(CASE WHEN ISNUMERIC(Grades.grade_value) = 1 THEN CAST(Grades.grade_value AS decimal) END), 3) AS grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Subjects.subject_name, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number) AS A LEFT JOIN (SELECT Subjects.subject_name, Grades.grade_value FROM Subjects INNER JOIN Performance ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}' AND Students.student_id = '{studentId}' GROUP BY Subjects.subject_name, Grades.grade_value, Students.student_name) AS B ON A.subject_name = B.subject_name GROUP BY A.subject_name, A.typeOfCertification_name, A.semester_number, B.grade_value";
            SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, GetConnection());
            SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

            while (readerGetPerformance.Read())
            {
                ReadSingleRowForCertainSemester(dataGridView, readerGetPerformance); // выводим успеваемость в DataGridView
            }
            readerGetPerformance.Close();
            CloseConnection();
        }
        public List<string> GetGroupGradesForCertainSemester(int groupId, int semesterNumber)
        {
            OpenConnection();
            List<string> listNumericOrStringGrades = new List<string>(); // список отметок в изначальном строковом формате

            // -- получаем все отметки студентОВ из группы студента, зашедшего в систему          
            string queryStringGetStudentsGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Groups.group_id = '{groupId}' AND Semesters.semester_number = '{semesterNumber}'";
            SqlCommand sqlCommandGetStudentsGrades = new SqlCommand(queryStringGetStudentsGrades, GetConnection());
            SqlDataReader readerGetStudentsGrades = sqlCommandGetStudentsGrades.ExecuteReader();
            while (readerGetStudentsGrades.Read())
            {
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGrades.Add(readerGetStudentsGrades.GetString(0));
            }
            readerGetStudentsGrades.Close();
            CloseConnection();
            return listNumericOrStringGrades;
        }
        public List<string> GetStudentGradesForCertainSemester(int studentId, int semesterNumber)
        {
            OpenConnection();
            List<string> listNumericOrStringGradesForOneStudent = new List<string>(); // список отметок в изначальном строковом формате

            // -- получаем все отметки студентА, зашедшего в систему          
            string queryStringGetStudentGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Students.student_id = '{studentId}' AND Semesters.semester_number = '{semesterNumber}'";
            SqlCommand sqlCommandGetStudentGrades = new SqlCommand(queryStringGetStudentGrades, GetConnection());
            SqlDataReader readerGetStudentGrades = sqlCommandGetStudentGrades.ExecuteReader();
            while (readerGetStudentGrades.Read())
            {
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGradesForOneStudent.Add(readerGetStudentGrades.GetString(0));
            }
            readerGetStudentGrades.Close();
            CloseConnection();
            return listNumericOrStringGradesForOneStudent;
        }

        // CertainSubject
        // заполнение DataGridView
        private void ReadSingleRowForCertainSubject(DataGridView dataGridView, IDataRecord record)
        {
            string studentFIO = record.IsDBNull(0) ? "-" : record.GetString(0);
            string studentGradeValue = record.IsDBNull(1) ? "-" : record.GetString(1);

            dataGridView.Rows.Add(studentFIO, studentGradeValue);
        }

        public void GetPerformanceForStudentForCertainSubject(int studentId, int groupId, DataGridView dataGridView, string subjectName, int semesterNumber)
        {
            OpenConnection();
            // -- получаем успеваемость для студента, вошедшего в систему -- // 
            //string queryStringGetPerformanceByStudentId = $"SELECT CASE WHEN Students.student_id = '{studentId}' THEN CONCAT(Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym) ELSE '-' END AS 'Студент', B.grade_value AS 'Отметка', COALESCE(A.typeOfCertification_name, B.typeOfCertification_name) AS 'Вид аттестации' FROM Students JOIN Groups ON Students.group_id = Groups.group_id LEFT JOIN (SELECT Performance.student_id, Types_Of_Certification.typeOfCertification_name FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Performance.student_id, Types_Of_Certification.typeOfCertification_name) AS A ON Students.student_id = A.student_id LEFT JOIN (SELECT Performance.student_id, Grades.grade_value, Types_Of_Certification.typeOfCertification_name FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{comboBoxCertainSubject.Text}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Performance.student_id, Grades.grade_value, Types_Of_Certification.typeOfCertification_name) AS B ON Students.student_id = B.student_id WHERE Groups.group_id = '{groupId}' GROUP BY Students.student_id, Students.student_name, Students.student_surname, Students.student_patronym, B.grade_value, A.typeOfCertification_name, B.typeOfCertification_name ORDER BY CASE WHEN B.grade_value = N'зачтено' THEN 1 WHEN B.grade_value = '5' THEN 2 WHEN B.grade_value = '4' THEN 3 WHEN B.grade_value = '3' THEN 4 WHEN B.grade_value = N'не зачтено' THEN 5 ELSE 6 END;";
            string queryStringGetPerformanceByStudentId = $"SELECT CASE WHEN Students.student_id = '{studentId}' THEN CONCAT(Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym) ELSE '-' END AS 'Студент', B.grade_value AS 'Отметка' FROM Students INNER JOIN Groups ON Students.group_id = Groups.group_id LEFT JOIN (SELECT Performance.student_id FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{subjectName}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Performance.student_id) AS A ON Students.student_id = A.student_id LEFT JOIN (SELECT Performance.student_id, Grades.grade_value FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{subjectName}' AND Semesters.semester_number = '{semesterNumber}' GROUP BY Performance.student_id, Grades.grade_value) AS B ON Students.student_id = B.student_id WHERE Groups.group_id = '{groupId}' GROUP BY Students.student_id, Students.student_name, Students.student_surname, Students.student_patronym, B.grade_value ORDER BY CASE WHEN B.grade_value = N'зачтено' THEN 1 WHEN B.grade_value = '5' THEN 2 WHEN B.grade_value = '4' THEN 3 WHEN B.grade_value = '3' THEN 4 WHEN B.grade_value = N'не зачтено' THEN 5 ELSE 6 END;";
            SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, GetConnection());
            SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

            while (readerGetPerformance.Read())
            {
                ReadSingleRowForCertainSubject(dataGridView, readerGetPerformance); // выводим успеваемость в DataGridView
            }
            readerGetPerformance.Close();
            CloseConnection();
        }
        public List<string> GetGroupGradesForCertainSubject(int groupId, string subjectName, int semesterNumber)
        {
            OpenConnection();
            List<string> listNumericOrStringGrades = new List<string>(); // список отметок в изначальном строковом формате

            // -- получаем все отметки студентОВ из группы студента, зашедшего в систему          
            string queryStringGetStudentsGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id WHERE Groups.group_id = '{groupId}' AND Semesters.semester_number = '{semesterNumber}' AND Subjects.subject_name = N'{subjectName}'";
            SqlCommand sqlCommandGetStudentsGrades = new SqlCommand(queryStringGetStudentsGrades, GetConnection());
            SqlDataReader readerGetStudentsGrades = sqlCommandGetStudentsGrades.ExecuteReader();
            while (readerGetStudentsGrades.Read())
            {
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGrades.Add(readerGetStudentsGrades.GetString(0));
            }
            readerGetStudentsGrades.Close();
            CloseConnection();
            return listNumericOrStringGrades;
        }
        public ComboBox GetSemesters(string subjectName, ComboBox comboBoxCertainSemester)
        {
            OpenConnection();
            // -- получаем семестры, в которых есть выбранный предмет
            string queryStringGetSemestersForSubject = $"SELECT DISTINCT Semesters.semester_number FROM Performance INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id WHERE Subjects.subject_name = N'{subjectName}'";
            SqlCommand sqlCommandGetSemestersForSubject = new SqlCommand(queryStringGetSemestersForSubject, GetConnection());
            SqlDataReader readerGetSemestersForSubject = sqlCommandGetSemestersForSubject.ExecuteReader();

            while (readerGetSemestersForSubject.Read())
            {
                comboBoxCertainSemester.Items.Add(readerGetSemestersForSubject.GetByte(0));
            }
            readerGetSemestersForSubject.Close();
            CloseConnection();
            return comboBoxCertainSemester;
        }

        public string GetTypeOfCertificationName(string subjectName, int semesterNumber)
        {
            OpenConnection();
            string queryStringGetTypeOfCertification = $"SELECT DISTINCT Types_Of_Certification.typeOfCertification_name FROM Performance INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Subjects.subject_name = N'{subjectName}' AND Semesters.semester_number = '{semesterNumber}'";
            SqlCommand sqlCommandGetTypeOfCertification = new SqlCommand(queryStringGetTypeOfCertification, GetConnection());
            SqlDataReader readerGetTypeOfCertification = sqlCommandGetTypeOfCertification.ExecuteReader();

            string typeOfCertificationName = "";
            while (readerGetTypeOfCertification.Read())
            {
                typeOfCertificationName = readerGetTypeOfCertification.GetString(0);
            }
            readerGetTypeOfCertification.Close();
            CloseConnection();
            return typeOfCertificationName;
        }
        public ComboBox GetSubjects(ComboBox comboBoxCertainSubject)
        {
            OpenConnection();
            // -- получаем список предметов для вывода в comboBoxCertainSubject
            string queryStringGetSubjectsName = "SELECT subject_name FROM Subjects";
            SqlCommand sqlCommandGetSubjectsName = new SqlCommand(queryStringGetSubjectsName, GetConnection());
            SqlDataReader readerGetSubjectsName = sqlCommandGetSubjectsName.ExecuteReader();
            while (readerGetSubjectsName.Read())
            {
                comboBoxCertainSubject.Items.Add(readerGetSubjectsName.GetString(0));
            }
            readerGetSubjectsName.Close();
            CloseConnection();
            return comboBoxCertainSubject;
        }
    }
}