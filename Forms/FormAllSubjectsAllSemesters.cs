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

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record, string grade)
        {
            //dataGridView.Rows.Add(record.GetString(0), record.GetString(1), record.GetFloat(2),
            //    record.GetString(3), record.GetByte(4));
            dataGridView.Rows.Add(record.GetString(0), record.GetString(1), grade,
                record.GetString(2), record.GetByte(3));
            // RoWState.ModifiedNew);
        }

        private void RefreshDataGridView(DataGridView dataGridView)
        {
            // -- переменные -- //
            List<string> listNumericOrStringGradesForCertainSubject = new List<string>(); // список отметок в изначальном строковом формате
            List<float> listNumericGradesForCertainSubject = new List<float>(); // список числовых отметок
            int countNumericGradeForCertainSubject = 0;
            float studentGPAForCertainSubject = 0; // средний балл отметок студентов            

            //////////////////////////////////////////////////////////////////////////////
           
            // -- получаем отметки из группы студента, зашедшего в систему и ПО ОПРЕДЕЛЕННОМУ ПРЕДМЕТУ        
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
            string queryStringGetPerformanceByStudentId = $"SELECT Subjects.subject_name, Grades.grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Performance.student_id = '{studentId}'";
            SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, sqlConnection);
            SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

            while (readerGetPerformance.Read())
            {                
                ReadSingleRow(dataGridView, readerGetPerformance, "Средний балл такой-то"); // !выводим успеваемость в DataGridView!
            }            
            readerGetPerformance.Close();


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