using StudentRating.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentRating
{
    public partial class FormRatingJournal : Form
    {
        private Button currentButton; // текущая кнопка
        private Form activeForm; // активная форма

        public int studentIdFromRatingJournal;
        public int groupIdFromRatingJournal;

        // конструктор формы Журнал рейтинга (родительская форма для остальных форм, связанных с журналом)
        public FormRatingJournal(int studentIdFromRatingJournal, int groupIdFromRatingJournal)
        {
            InitializeComponent();
            this.studentIdFromRatingJournal = studentIdFromRatingJournal;
            this.groupIdFromRatingJournal = groupIdFromRatingJournal;
        }
        private void FormRatingJournal_Load(object sender, EventArgs e)
        {
            buttonAllSubjectsAllSemesters.PerformClick();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    int red = Convert.ToInt32(63);
                    int green = Convert.ToInt32(81);
                    int blue = Convert.ToInt32(181);
                    Color color = Color.FromArgb(red, green, blue);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(98, 102, 244);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(childForm);
            panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleBar.Text = childForm.Text;
        }

        // событие клика на кнопку "Журнал рейтинга за все семестры по всем предметам"
        private void buttonAllSubjectsAllSemesters_Click(object sender, EventArgs e)
        {
            FormAllSubjectsAllSemesters formAllSubjectsAllSemesters = new FormAllSubjectsAllSemesters(studentIdFromRatingJournal, groupIdFromRatingJournal);
            
            OpenChildForm(formAllSubjectsAllSemesters, sender);
        }

        // событие клика на кнопку "Журнал рейтинга за определенный семестр"
        private void buttonCertainSemester_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCertainSemester(studentIdFromRatingJournal, groupIdFromRatingJournal), sender);
        }

        // событие клика на кнопку "Журнал рейтинга по определенному предмету"
        private void buttonCertainSubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCertainSubject(studentIdFromRatingJournal, groupIdFromRatingJournal), sender);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из личного кабинета?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormAuthorization formAuthorization = new FormAuthorization();
                Hide();
                formAuthorization.ShowDialog();
                Close();
            }
        }
    }
}
