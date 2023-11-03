using System;
using StudentRating.Classes;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace StudentRating
{
    public partial class FormAuthorization : Form
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();

        public int studentIdFromFormAuthorization;
        public int groupIdFromFormAuthorization;

        public FormAuthorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // форма будет по центру
        }
        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            dataBaseConnection.OpenConnection();
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

                // два класса для работы с БД
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                SqlCommand sqlCommand = new SqlCommand(querySelectStudent, dataBaseConnection.GetConnection());

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    // получаем studentId по логину пользователя для передачи studentId на другие формы
                    string queryGetStudentIdByLogin = $"SELECT student_id FROM Students WHERE student_login = '{textBoxLogin.Text}'";
                    SqlCommand sqlCommandGetStudentIdByLogin = new SqlCommand(queryGetStudentIdByLogin, dataBaseConnection.GetConnection());
                    SqlDataReader readerGetStudentIdByLogin = sqlCommandGetStudentIdByLogin.ExecuteReader();
                    while (readerGetStudentIdByLogin.Read())
                    {
                        studentIdFromFormAuthorization = readerGetStudentIdByLogin.GetInt32(0);                        
                    }
                    readerGetStudentIdByLogin.Close();

                    // получаем groupId по studentId для передачи groupId на другие формы
                    string queryGetGroupId = $"SELECT Groups.group_id FROM Students INNER JOIN Groups ON Students.group_id = Groups.group_id WHERE Students.student_id = '{studentIdFromFormAuthorization}'";
                    SqlCommand sqlCommandGetGroupId = new SqlCommand(queryGetGroupId, dataBaseConnection.GetConnection());
                    SqlDataReader readerGetGroupId = sqlCommandGetGroupId.ExecuteReader();
                    while (readerGetGroupId.Read())
                    {
                        groupIdFromFormAuthorization = readerGetGroupId.GetInt32(0);                        
                    }
                    readerGetGroupId.Close();
                    
                    FormRatingJournal formRatingJournal = new FormRatingJournal(studentIdFromFormAuthorization, groupIdFromFormAuthorization);
                    
                    // берем ФИО студента для отображения на лэйбле FormRatingJournal
                    string querySelectStudentNameByLogin = $"SELECT CONCAT (Students.student_surname, ' ', Students.student_name, ' ', Students.student_patronym) FROM Students WHERE student_login = '{textBoxLogin.Text}'";
                    SqlCommand sqlCommandSelectStudentNameByLogin = new SqlCommand(querySelectStudentNameByLogin, dataBaseConnection.GetConnection());                    
                    SqlDataReader reader = sqlCommandSelectStudentNameByLogin.ExecuteReader();
                    while (reader.Read())
                    {
                        String FIOstudent = reader.GetString(0);
                        formRatingJournal.labelFIOStudent.Text = FIOstudent;
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
            dataBaseConnection.CloseConnection();
        }
    }
}
