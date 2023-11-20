using StudentRating.Classes;
using System.Collections.Generic;

namespace StudentRating
{
    public class ControllerAuthorization
    {
        private static DataBase dataBase = new DataBase();

        // получить studentId по логину и паролю
        public static List<int> GetStudentIdGroupId(string login, string password)
        {
            return dataBase.GetStudentIdGroupId(login, password);
        }
        // установить ФИО студента на панели журнала рейтинга
        public static void SetFIOForRatingJournal(string login, RatingJournal ratingJournal)
        {
            string FIOstudent = dataBase.SetFIOForRatingJournal(login, ratingJournal);
            ratingJournal.labelFIOStudent.Text = FIOstudent;
        }
    }
}
