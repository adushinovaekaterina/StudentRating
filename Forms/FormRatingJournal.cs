using StudentRating.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRating
{
    public partial class FormRatingJournal : Form
    {
        private Button currentButton; // текущая кнопка
        private Random random; // рандом
        private int tempIndex; // временный индекс
        private Form activeForm; // активная форма

        public int studentIdFromRatingJournal = 15;

        // конструктор формы Журнал рейтинга (родительская форма для остальных форм, связанных с журналом)
        public FormRatingJournal(int studentIdFromRatingJournal)
        {
            InitializeComponent();

            random = new Random();

            this.studentIdFromRatingJournal = studentIdFromRatingJournal;
        }

        private void FormRatingJournal_Load(object sender, EventArgs e)
        {
            buttonAllSubjectsAllSemesters.PerformClick();
        }

        private void CollapseMenu()
        {
            // скрыть меню
            if (this.panelMenu.Width > 200) 
            {
                panelMenu.Width = 100;
                // Controls возвращает коллекцию элементов управления, содержащихся в элементе управления
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            // развернуть меню
            else
            { 
                panelMenu.Width = 250;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                    //panelTitleBar.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
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
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleBar.Text = childForm.Text;
        }

        // событие клика на кнопку "Гамбургер-меню"
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        // событие клика на кнопку "Журнал рейтинга за все семестры по всем предметам"
        private void buttonAllSubjectsAllSemesters_Click(object sender, EventArgs e)
        {
            FormAllSubjectsAllSemesters formAllSubjectsAllSemesters = new FormAllSubjectsAllSemesters(studentIdFromRatingJournal);
            
            OpenChildForm(formAllSubjectsAllSemesters, sender);
        }

        // событие клика на кнопку "Журнал рейтинга за определенный семестр"
        private void buttonCertainSemester_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCertainSemester(), sender);
        }

        // событие клика на кнопку "Журнал рейтинга по определенному предмету"
        private void buttonCertainSubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCertainSubject(), sender);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из личного кабинета?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormAuthorization formAuthorization = new FormAuthorization();
                this.Hide();
                formAuthorization.ShowDialog();
                this.Close();
            }
        }
    }
}
