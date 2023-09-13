using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRating.Classes;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using StudentRating.Forms;

namespace StudentRating
{
    public partial class FormAuthorization : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        // поле для создания подключения к БД
        // благодаря классу SqlConnection происходят все операции с БД
        // через созданное открытое подключение
        private SqlConnection sqlConnection = null;

        public int studentIdFromFormAuthorization;
        public int groupIdFromFormAuthorization;

        public FormAuthorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // форма будет по центру
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
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

            //// проверка, установилось ли подключение к БД
            //if (sqlConnection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Подключение к БД установлено!");
            //}
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если вы забыли пароль, то напишите на почту adushinova2002@mail.ru", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            pictureBoxEyeSlash.Visible = true;
            pictureBoxEye.Visible = false;
            textBoxPassword.PasswordChar = '\0';
        }

        private void pictureBoxEyeSlash_Click(object sender, EventArgs e)
        {            
            pictureBoxEyeSlash.Visible = false;
            pictureBoxEye.Visible = true;
            textBoxPassword.PasswordChar = '•';
        }

        private void labelWithoutAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если у вас нет аккаунта в системе 'Журнал рейтинга студентов', то напишите на почту adushinova2002@mail.ru", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLogin.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                // sql-запрос, чтобы выбрать записи, где student_login = textBoxLogin
                // и student_password = textBoxPassword
                string querySelectStudent = $"SELECT student_id, student_login, student_password FROM Students WHERE student_login = '{textBoxLogin.Text}' and student_password = '{textBoxPassword.Text}'";


                /////!!!!! может и не понадобится, но на всякий напишу
                //string queryGetStudentId = $"SELECT student_id FROM Students WHERE student_login = '{textBoxLogin.Text}'";
                //// объект класса SqlCommand, в который заносим запрос queryGetStudentId и подключение к БД
                //SqlCommand sqlCommandGetStudentId = new SqlCommand(queryGetStudentId, dataBaseConnection.getConnection());
                /////!!!!! может и не понадобится, но на всякий напишу

                //dataBaseConnection.openConnection();

                // два класса для работы с БД
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                SqlCommand sqlCommand = new SqlCommand(querySelectStudent, sqlConnection);

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    // 1)
                    string queryGetStudentIdByLogin = $"SELECT student_id FROM Students WHERE student_login = '{textBoxLogin.Text}'";

                    // 2)
                    SqlCommand sqlCommandGetStudentIdByLogin = new SqlCommand(queryGetStudentIdByLogin, sqlConnection);

                    // 3)
                    SqlDataReader readerGetStudentIdByLogin = sqlCommandGetStudentIdByLogin.ExecuteReader();

                    // 4) 
                    while (readerGetStudentIdByLogin.Read())
                    {
                        studentIdFromFormAuthorization = readerGetStudentIdByLogin.GetInt32(0);                        
                    }
                    // 5)
                    readerGetStudentIdByLogin.Close();

                    // 1)
                    string queryGetGroupId = $"SELECT Groups.group_id FROM Students INNER JOIN Groups ON Students.group_id = Groups.group_id WHERE Students.student_id = '{studentIdFromFormAuthorization}'";

                    // 2)
                    SqlCommand sqlCommandGetGroupId = new SqlCommand(queryGetGroupId, sqlConnection);

                    // 3)
                    SqlDataReader readerGetGroupId = sqlCommandGetGroupId.ExecuteReader();

                    // 4) 
                    while (readerGetGroupId.Read())
                    {
                        groupIdFromFormAuthorization = readerGetGroupId.GetInt32(0);                        
                    }
                    // 5)
                    readerGetGroupId.Close();


                    // берем ФИО студента для отображения на лэйбле FormRatinJournal
                    FormRatingJournal formRatingJournal = new FormRatingJournal(studentIdFromFormAuthorization, groupIdFromFormAuthorization);

                    string querySelectStudentNameByLogin = $"SELECT CONCAT (Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym) FROM Students WHERE student_login = '{textBoxLogin.Text}'";
                    
                    SqlCommand sqlCommandSelectStudentNameByLogin = new SqlCommand(querySelectStudentNameByLogin, sqlConnection);
                    
                    SqlDataReader reader = sqlCommandSelectStudentNameByLogin.ExecuteReader();

                    while (reader.Read())
                    {
                        String nameStudent = reader.GetString(0);

                        formRatingJournal.labelNameStudent.Text = nameStudent;
                    }
                    reader.Close();
                    this.Hide();
                    formRatingJournal.ShowDialog();
                    this.Close();
                }                
                else
                {
                    MessageBox.Show("Неверный пароль и/или логин!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword.Clear();
                }
            }
            else if (textBoxLogin.Text == String.Empty && textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Select();
            }
            else if (textBoxLogin.Text == String.Empty)
            {
                MessageBox.Show("Введите логин!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Select();
            }
            else if (textBoxPassword.Text == String.Empty || textBoxPassword.Text == "\n")
            {
                MessageBox.Show("Введите пароль!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Select();
            }
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                e.Handled = true;
                e.SuppressKeyPress = true;
                textBoxPassword.Select();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                buttonSignIn_Click(sender, e);
            }
        }

        private void FormAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
