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

        public FormAllSubjectsAllSemesters()
        {
            InitializeComponent();            
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
            dgw.Rows.Clear();

            //string queryString = $"SELECT CONCAT (Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym), Subjects.subject_name, Semesters.semester_number, Grades.grade_value, Types_Of_Certification.typeOfCertification_name FROM Performance JOIN Students ON Performance.student_id = Students.student_id JOIN Subjects ON Performance.subject_id = Subjects.subject_id JOIN Semesters ON Performance.semester_id = Semesters.semester_id JOIN Grades ON Performance.grade_id = Grades.grade_id JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id";

            //string queryString = $"SELECT Subjects.subject_name, Grades.grade_value, CAST(Grades.grade_value AS INT), Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance JOIN Subjects ON Performance.subject_id = Subjects.subject_id JOIN Grades ON Performance.grade_id = Grades.grade_id JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id JOIN Semesters ON Performance.semester_id = Semesters.semester_id";

            string queryString = $"SELECT Subjects.subject_name, Grades.grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance JOIN Subjects ON Performance.subject_id = Subjects.subject_id JOIN Grades ON Performance.grade_id = Grades.grade_id JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id JOIN Semesters ON Performance.semester_id = Semesters.semester_id";

            SqlCommand command = new SqlCommand(queryString, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();        
        }
    }
}
