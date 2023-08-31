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

        int selectedRow;

        public int studentId;

        private int countNumericGrade = 0;

        private float[] studentGPA;

        public FormAllSubjectsAllSemesters(int studentId)
        {
            InitializeComponent();  
            this.studentId = studentId;            
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
            RefreshDataGrid(dataGridViewAllSubjectsAllSemesters);
            dataGridViewAllSubjectsAllSemesters.ClearSelection(); // убираем выделение первой левой ячейки
        }

        private void CreateColumns()
        {
            dataGridViewAllSubjectsAllSemesters.Columns.Add("subject_name", "Предмет");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("grade_value", "Моя отметка");
            //dataGridViewAllSubjectsAllSemesters.Columns.Add("grade_value", "Средний балл в группе");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("typeOfCertification_name", "Вид аттестации");
            dataGridViewAllSubjectsAllSemesters.Columns.Add("semester_number", "Семестр");            
            //dataGridViewAllSubjectsAllSemesters.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            //dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetFloat(2),
            //    record.GetString(3), record.GetByte(4));
            dgw.Rows.Add(record.GetString(0), record.GetString(1),
                record.GetString(2), record.GetByte(3));
            // RoWState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {           
            //dgw.Rows.Clear();

            // 1)
            string queryStringGetPerformanceByStudentId = $"SELECT Subjects.subject_name, Grades.grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id WHERE Performance.student_id = '{studentId}'";
            
            // 2)
            SqlCommand sqlCommandGetPerformanceByStudentId = new SqlCommand(queryStringGetPerformanceByStudentId, sqlConnection);

            // 3)
            SqlDataReader readerGetPerformance = sqlCommandGetPerformanceByStudentId.ExecuteReader();

            // 4) 
            while(readerGetPerformance.Read())
            {
                ReadSingleRow(dgw, readerGetPerformance);
            }
            // 5)
            readerGetPerformance.Close();


            // список отметок в изначальном строковом формате
            List<string> listNumericOrStringGrades = new List<string>(); 

            List<float> listNumericGrades = new List<float>(); // список числовых отметок

            float studentGPA = 0; // средний балл отметок студентов

            // 1) получаем все отметки студентов
            string queryStringGetStudentGrades = $"SELECT Grades.grade_value FROM Performance INNER JOIN Grades ON Performance.grade_id = Grades.grade_id";

            // 2) 
            SqlCommand sqlCommandGetStudentGrades = new SqlCommand(queryStringGetStudentGrades, sqlConnection);

            // 3) 
            SqlDataReader readerGetStudentGrades = sqlCommandGetStudentGrades.ExecuteReader();

            int ordinalNumber = readerGetStudentGrades.GetOrdinal("grade_value"); // получаем номер колонки Grades.grade_value

            // 4) 
            while (readerGetStudentGrades.Read())
            {
                labelStudentGrades.Text = "";
                listNumericOrStringGrades.Add(readerGetStudentGrades.GetString(ordinalNumber)); // читаем текст из колонки под номером ordinalNumber
                
                for (int i = 0; i < listNumericOrStringGrades.Count(); i++)
                {                    
                    labelStudentGrades.Text += " " + listNumericOrStringGrades[i];
                }
            }

            for (int i = 0; i < listNumericOrStringGrades.Count(); i++)
            {
                int numericGrade; // конвертированная в численный тип отметка
                bool isNumber = int.TryParse(listNumericOrStringGrades[i], out numericGrade);
                if (isNumber)
                {
                    labelNumericGrade.Text += " " + numericGrade.ToString();
                    listNumericGrades.Add(numericGrade);
                    countNumericGrade++;
                }
                else
                {
                    labelStringGrade.Text += " " + listNumericOrStringGrades[i];
                }
            }

            studentGPA = listNumericGrades.Sum() / listNumericGrades.Count();
            labelStudentGPA.Text += " " + studentGPA.ToString();


            // 5) 
            readerGetStudentGrades.Close();

        }
    }
}
