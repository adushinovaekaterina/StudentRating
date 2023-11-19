using StudentRating.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentRating
{
    public class ControllerCertainSubject
    {
        static DataBase dataBase = new DataBase();

        // получить успеваемость студента для dataGridView
        public static void GetPerformanceForStudent(int studentId, int groupId, DataGridView dataGridView, string subjectName, int semesterNumber)
        {
            dataBase.GetPerformanceForStudentForCertainSubject(studentId, groupId, dataGridView, subjectName, semesterNumber);
        }
        // получить название группы
        public static string GetGroupName(int groupId)
        {
            return dataBase.GetGroupName(groupId);
        }
        // рассчитать средний балл в группе
        public static float GetGroupGPA(int groupdId, string subjectName, int semesterNumber)
        {
            // получаем отметки студентОВ в группе
            List<string> listNumericOrStringGrades = new List<string>();
            listNumericOrStringGrades = dataBase.GetGroupGradesForCertainSubject(groupdId, subjectName, semesterNumber);

            List<float> listNumericGrades = new List<float>(); // список числовых отметок

            for (int i = 0; i < listNumericOrStringGrades.Count(); i++) // проходимся по всем отметкам в списке
            {
                int numericGrade; // конвертированная в численный тип отметка
                bool isNumber = int.TryParse(listNumericOrStringGrades[i], out numericGrade);
                if (isNumber) // если отметка числовая, то добавляем ее в список числовых отметок
                {
                    listNumericGrades.Add(numericGrade);
                }
            }
            float groupGPA = -1; // средний балл отметок студентов
            if (listNumericGrades.Count != 0)
            {
                // высчитываем средний балл всех студентов группы по всем предметам за все семестры
                groupGPA = (float)Math.Round(listNumericGrades.Sum() / listNumericGrades.Count(), 1);
            }
            return groupGPA;
        }
        // получить название вида аттестации
        public static string GetTypeOfCertification(string subjectName, int semesterNumber)
        {
            return dataBase.GetTypeOfCertificationName(subjectName, semesterNumber);
        }
    }
}
