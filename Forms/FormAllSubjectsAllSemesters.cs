using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using System.Xml;

namespace StudentRating.Forms
{
    enum RoWState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class FormAllSubjectsAllSemesters : Form
    {
        // поле для создания подключения к БД
        // благодаря классу SqlConnection происходят все операции с БД
        // через созданное открытое подключение
        private SqlConnection sqlConnection = null;

        //DataBase database = new DataBase();

        public int studentId;
        public int groupId;

        public FormAllSubjectsAllSemesters(int studentId, int groupId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.groupId = groupId;
        }

        private void FormAllSubjectsAllSemesters_Load(object sender, EventArgs e)
        {
            // для того чтобы вытащить строку подключения из файла настроек нужно прописать это:
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDatabaseStudentRating"].ConnectionString);
            // нужен класс ConfigurationManager и его свойство ConnectionStrings
            // (это словарь и по ключу мы можем получать значения
            // ключом является "ConnectionStringsDatabaseStudentRating")
            // но если не написать в конце ConnectionString, то вернется вся строка подключения
            // а у нее есть имя, сама строка подключения = путь к БД (она нам и нужна)

            // открываем подключение к БД, иначе ничего не будет работать
            sqlConnection.Open();

            CreateColumns();
            RefreshDataGridView(dataGridViewAllSubjectsAllSemesters);
            dataGridViewAllSubjectsAllSemesters.ClearSelection(); // убираем выделение первой левой ячейки
        }

        private void CreateColumns()
        {
            dataGridViewAllSubjectsAllSemesters.Columns.Add("subject_name", "Предмет");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("grade_value", "Моя отметка");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("grade_value", "Средний балл в группе");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("typeOfCertification_name", "Вид аттестации");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("semester_number", "Семестр");
            
            //dataGridViewAllSubjectsAllSemesters.Columns.Add("IsNew", String.Empty);
        }

        //private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        //{
        //    //dataGridView.Rows.Add(record.GetString(0), record.GetString(1), record.GetFloat(2),
        //    //    record.GetString(3), record.GetByte(4));
        //    ///////////////////dataGridView.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2),
        //       ///////////////////////// record.GetString(3), record.GetByte(4));
        //    // RoWState.ModifiedNew);

        //    string subjectName = record.IsDBNull(0) ? "нету" : record.GetString(0);
        //    string gradeValue = record.IsDBNull(1) ? "нету" : record.GetString(1);
        //    string averageGrade = record.IsDBNull(2) ? "нету" : record.GetString(2);
        //    string typeOfCertification = record.IsDBNull(3) ? "нету" : record.GetString(3);
        //    byte semesterNumber = record.IsDBNull(4) ? (byte)0 : record.GetByte(4);

        //    dataGridView.Rows.Add(subjectName, gradeValue, averageGrade, typeOfCertification, semesterNumber);
        //}

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            string subjectName = record.IsDBNull(0) ? "" : record.GetString(0);
            string studentGradeValue = record.IsDBNull(1) ? "" : record.GetString(1);
            decimal averageGrade = record.IsDBNull(2) ? 0 : record.GetDecimal(2);
            string typeOfCertification = record.IsDBNull(3) ? "" : record.GetString(3);
            byte semester = (byte)(record.IsDBNull(4) ? 0 : record.GetByte(4));

            dataGridView.Rows.Add(subjectName, studentGradeValue, averageGrade, typeOfCertification, semester);
            //var d1 = dataGridView[2, 0].Value;
            //var d2 = dataGridView[2, 1].Value;
        }

        //private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        //{
        //    //dataGridView.Rows.Add(record.GetString(0), record.GetString(1), record.GetFloat(2),
        //    //    record.GetString(3), record.GetByte(4));
        //    dataGridView.Rows.Add(record.GetString(0), record.GetString(1),
        //        record.GetString(2), record.GetByte(3));
        //    // RoWState.ModifiedNew);
        //}

        //private string IsZachteno (IDataRecord record, int i)
        //{

        //    if (record.GetString(i) == "зачтено")
        //    {
        //        return record.GetString(i);
        //    } else
        //    {
        //        return record.GetString(i)    ;        
        //    }

        //}


        //private string GetSafeString(IDataRecord record, int index)
        //{
        //    if (!record.IsDBNull(index))
        //    {
        //        string value = record.GetString(index);
        //        int maxLength = 100; // Здесь вы можете указать максимальную длину столбца
        //        return value.Length > maxLength ? value.Substring(0, maxLength) : value;
        //    }
        //    return "";
        //}

        private void RefreshDataGridView(DataGridView dataGridView)
        {
            // -- переменные -- //
            List<string> listNumericOrStringGradesForCertainSubject = new List<string>(); // список отметок в изначальном строковом формате
            List<float> listNumericGradesForCertainSubject = new List<float>(); // список числовых отметок
            int countNumericGradeForCertainSubject = 0;
            float studentGPAForCertainSubject = 0; // средний балл отметок студентов            

            //////////////////////////////////////////////////////////////////////////////

            // -- получаем отметки всех студентов из группы студента, зашедшего в систему и ПО ОПРЕДЕЛЕННОМУ ПРЕДМЕТУ        
            string queryStringGetStudentGradesForCertainSubject = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id INNER JOIN Subjects ON Subjects.subject_id = Performance.subject_id WHERE Groups.group_id = '{groupId}' AND Subjects.subject_id = 1";
            SqlCommand sqlCommandGetStudentGradesForCertainSubject = new SqlCommand(queryStringGetStudentGradesForCertainSubject, sqlConnection);
            SqlDataReader readerGetStudentGradesForCertainSubject = sqlCommandGetStudentGradesForCertainSubject.ExecuteReader();
            int ordinalNumberCertainSubject = readerGetStudentGradesForCertainSubject.GetOrdinal("grade_value"); // получаем порядковый номер столбца Grades.grade_value
            while (readerGetStudentGradesForCertainSubject.Read())
            {
                //labelStudentGradesForCertainSubject.Text = "";

                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGradesForCertainSubject.Add(readerGetStudentGradesForCertainSubject.GetString(ordinalNumberCertainSubject));
                // выводим все отметки в лейбл для всех отметок
                for (int i = 0; i < listNumericOrStringGradesForCertainSubject.Count(); i++)
                {
                    labelStudentGradesForCertainSubject.Text += " " + listNumericOrStringGradesForCertainSubject[i];
                }
            }
            readerGetStudentGradesForCertainSubject.Close();

            // -- выводим отметки в лейбл для числовых и в лейбл для строковых отметок -- //            
            for (int i = 0; i < listNumericOrStringGradesForCertainSubject.Count(); i++) // проходимся по всем отметкам в списке
            {
                int numericGrade; // конвертированная в численный тип отметка
                bool isNumber = int.TryParse(listNumericOrStringGradesForCertainSubject[i], out numericGrade);
                if (isNumber) // если отметка числовая, то выводим ее в соответствующий лейбл
                {
                    labelNumericGradesForCertainSubject.Text += " " + numericGrade.ToString();
                    listNumericGradesForCertainSubject.Add(numericGrade);
                    countNumericGradeForCertainSubject++;
                }
                else // иначе выводим в лейбл для строковых отметок
                {
                    labelStringGradesForCertainSubject.Text += " " + listNumericOrStringGradesForCertainSubject[i];

                }
            }
            // высчитываем средний балл всех студентов по всем предметам
            // (! нужно высчитывать средний балл отдельно для каждого предмета!)
            studentGPAForCertainSubject = (float)Math.Round(listNumericGradesForCertainSubject.Sum() / listNumericGradesForCertainSubject.Count(), 1);
            labelStudentGPAForCertainSubject.Text += " " + studentGPAForCertainSubject.ToString(); // выводим средний балл в соответствуюищй лейбл

            //////////////////////////////////////////////////////////////////////

            // -- получаем успеваемость для студента, вошедшего в систему -- // 
            //string queryStringGetPerformanceByStudentId = $"SELECT Subjects.subject_name, Grades.grade_value, CAST(AVG(CAST(Grades.grade_value AS INT)) AS VARCHAR) AS average_grade, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Performance.student_id = '{studentId}' AND ISNUMERIC(Grades.grade_value) = 1 GROUP BY Subjects.subject_name, Grades.grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number";
            // ошибка bound string queryStringGetPerformanceByStudentId = $"SELECT subquery.subject_name, subquery.grade_value, CAST(avg_grade.average_grade AS VARCHAR) AS average_grade FROM (SELECT Subjects.subject_name, Grades.grade_value AS grade_value FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id WHERE Performance.student_id = '{studentId}') AS subquery CROSS JOIN (SELECT AVG(TRY_CONVERT(INT, Grades.grade_value)) AS average_grade FROM Performance INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id WHERE Performance.student_id = '{studentId}') AS avg_grade INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id";
            // оригинал string queryStringGetPerformanceByStudentId = $"SELECT Subjects.subject_name, Grades.grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Performance.student_id = '{studentId}'"; 
            string queryStringGetPerformanceByStudentId = $"SELECT A.subject_name AS 'Предмет', B.grade_value AS 'Моя отметка', AVG(A.grade_value) AS 'Средний балл в группе', A.typeOfCertification_name AS 'Вид аттестации', A.semester_number AS 'Семестр' FROM (SELECT Subjects.subject_name, ROUND(AVG(CASE WHEN ISNUMERIC(Grades.grade_value) = 1 THEN CAST(Grades.grade_value AS decimal) END), 1) AS grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = 1 GROUP BY Subjects.subject_name, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number) AS A LEFT JOIN (SELECT Subjects.subject_name, Grades.grade_value FROM Subjects INNER JOIN Performance ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = 1 AND Students.student_id = 1 GROUP BY Subjects.subject_name, Grades.grade_value, Students.student_name) AS B ON A.subject_name = B.subject_name GROUP BY A.subject_name, A.typeOfCertification_name, A.semester_number, B.grade_value";
            SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, sqlConnection);
            SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

            while (readerGetPerformance.Read())
            {
                ReadSingleRow(dataGridView, readerGetPerformance); // !выводим успеваемость в DataGridView!
            }
            readerGetPerformance.Close();

            // ******************************************************

            // -- переменные -- //
            List<string> listNumericOrStringGrades1 = new List<string>(); // список отметок в изначальном строковом формате
            List<float> listNumericGrades1 = new List<float>(); // список числовых отметок
            int countNumericGrade1 = 0;
            float studentGPA1 = 0; // средний балл отметок студентов

            // -- получаем все отметки студентов ПО ПРЕДМЕТУ В DATAGRIDVIEW -- //  !нужны отметки из группы студента, зашедшего в систему          
            string queryStringGetStudentGrades1 = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id WHERE Groups.group_id = '{groupId}' AND Subjects.subject_id = 4";
            //string queryStringGetStudentGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id";
            SqlCommand sqlCommandGetStudentGrades1 = new SqlCommand(queryStringGetStudentGrades1, sqlConnection);
            SqlDataReader readerGetStudentGrades1 = sqlCommandGetStudentGrades1.ExecuteReader();
            int ordinalNumber1 = readerGetStudentGrades1.GetOrdinal("grade_value"); // получаем порядковый номер столбца Grades.grade_value
            while (readerGetStudentGrades1.Read())
            {
                //////////////labelStudentGrades.Text = "";
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGrades1.Add(readerGetStudentGrades1.GetString(ordinalNumber1));
                // выводим все отметки в лейбл для всех отметок
                for (int i = 0; i < listNumericOrStringGrades1.Count(); i++)
                {

                    labelStudentGrades.Text += " " + listNumericOrStringGrades1[i];
                }
            }
            readerGetStudentGrades1.Close();

            // -- выводим отметки в лейбл для числовых и в лейбл для строковых отметок -- //            
            for (int i = 0; i < listNumericOrStringGrades1.Count(); i++) // проходимся по всем отметкам в списке
            {
                int numericGrade; // конвертированная в численный тип отметка
                bool isNumber = int.TryParse(listNumericOrStringGrades1[i], out numericGrade);
                if (isNumber) // если отметка числовая, то выводим ее в соответствующий лейбл
                {
                    labelNumericGrades.Text += " " + numericGrade.ToString();
                    listNumericGrades1.Add(numericGrade);
                    countNumericGrade1++;
                }
                else // иначе выводим в лейбл для строковых отметок
                {
                    labelStringGrades.Text += " " + listNumericOrStringGrades1[i];

                }
            }
            // высчитываем средний балл всех студентов по всем предметам
            // (! нужно высчитывать средний балл отдельно для каждого предмета!)
            studentGPA1 = (float)Math.Round(listNumericGrades1.Sum() / listNumericGrades1.Count(), 1);
            labelStudentGPA.Text += " " + studentGPA1.ToString(); // выводим средний балл в соответствуюищй лейбл

            // ********************************************************

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            ////////////////string queryStringGetPerformanceByStudentId = $"SELECT Subjects.subject_id, Grades.grade_value FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Performance.student_id = '{studentId}'";
            ////////////////SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, sqlConnection);
            ////////////////SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

            ////////////////while (readerGetPerformance.Read())
            ////////////////{
            ////////////////    ReadSingleRow(dataGridView, readerGetPerformance, "Средний балл такой-то"); // !выводим успеваемость в DataGridView!
            ////////////////}
            ////////////////readerGetPerformance.Close();

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            // -- переменные -- //
            List<string> listNumericOrStringGrades = new List<string>(); // список отметок в изначальном строковом формате
            List<float> listNumericGrades = new List<float>(); // список числовых отметок
            int countNumericGrade = 0;
            float studentGPA = 0; // средний балл отметок студентов


            // -- получаем все отметки студентов -- //  !нужны отметки из группы студента, зашедшего в систему          
            string queryStringGetStudentGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Students ON Students.student_id = Performance.student_id INNER JOIN Groups ON Groups.group_id = Students.group_id WHERE Groups.group_id = '{groupId}'";
            //string queryStringGetStudentGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id";
            SqlCommand sqlCommandGetStudentGrades = new SqlCommand(queryStringGetStudentGrades, sqlConnection);
            SqlDataReader readerGetStudentGrades = sqlCommandGetStudentGrades.ExecuteReader();
            int ordinalNumber = readerGetStudentGrades.GetOrdinal("grade_value"); // получаем порядковый номер столбца Grades.grade_value
            while (readerGetStudentGrades.Read())
            {
                labelStudentGrades.Text = "";
                // добавляем в список всех оценок все отметки, полученные от sql-запроса
                listNumericOrStringGrades.Add(readerGetStudentGrades.GetString(ordinalNumber));
                // выводим все отметки в лейбл для всех отметок
                for (int i = 0; i < listNumericOrStringGrades.Count(); i++)
                {
                    labelStudentGrades.Text += " " + listNumericOrStringGrades[i];
                }
            }
            readerGetStudentGrades.Close();

            // -- выводим отметки в лейбл для числовых и в лейбл для строковых отметок -- //            
            for (int i = 0; i < listNumericOrStringGrades.Count(); i++) // проходимся по всем отметкам в списке
            {
                int numericGrade; // конвертированная в численный тип отметка
                bool isNumber = int.TryParse(listNumericOrStringGrades[i], out numericGrade);
                if (isNumber) // если отметка числовая, то выводим ее в соответствующий лейбл
                {
                    labelNumericGrades.Text += " " + numericGrade.ToString();
                    listNumericGrades.Add(numericGrade);
                    countNumericGrade++;
                }
                else // иначе выводим в лейбл для строковых отметок
                {
                    labelStringGrades.Text += " " + listNumericOrStringGrades[i];

                }
            }
            // высчитываем средний балл всех студентов по всем предметам
            // (! нужно высчитывать средний балл отдельно для каждого предмета!)
            studentGPA = (float)Math.Round(listNumericGrades.Sum() / listNumericGrades.Count(), 1);
            labelStudentGPA.Text += " " + studentGPA.ToString(); // выводим средний балл в соответствуюищй лейбл
        }
    }
}