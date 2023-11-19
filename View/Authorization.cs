using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace StudentRating
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLogin.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                List<int> listStudentIdGroupId = new List<int>();
                listStudentIdGroupId = ControllerAuthorization.GetStudentIdGroupId(textBoxLogin.Text, textBoxPassword.Text);
                if (listStudentIdGroupId != null)
                {                    
                    RatingJournal formRatingJournal = new RatingJournal(listStudentIdGroupId[0], listStudentIdGroupId[1]);
                    ControllerAuthorization.SetFIOForRatingJournal(textBoxLogin.Text, formRatingJournal);
                    Hide();
                    formRatingJournal.ShowDialog();
                    Close();
                }                
                else
                {
                    MessageBox.Show("Неверный пароль и/или логин!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword.Clear();
                }
            }
            else if (textBoxLogin.Text == string.Empty && textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Select();
            }
            else if (textBoxLogin.Text == string.Empty)
            {
                MessageBox.Show("Введите логин!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Select();
            }
            else if (textBoxPassword.Text == string.Empty || textBoxPassword.Text == "\n")
            {
                MessageBox.Show("Введите пароль!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Select();
            }
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
    }
}
