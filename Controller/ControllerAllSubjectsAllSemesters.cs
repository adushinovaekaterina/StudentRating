using StudentRating.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentRating
{
    public class ControllerAllSubjectsAllSemesters
    {
        private static DataBase dataBase = new DataBase();
        
        // получить успеваемость студента для dataGridView
        public static void GetPerformanceForStudent(int studentId, int groupId, DataGridView dataGridView)
        {
            dataBase.GetPerformanceForStudentForAllSubjectAllSemesters(studentId, groupId, dataGridView);
        }
        // получить название группы
        public static string GetGroupName(int groupId)
        {
            return dataBase.GetGroupName(groupId);
        }
        // рассчитать средний балл в группе
        public static float GetGroupGPA(int groupdId)
        {
            // получаем отметки студентОВ в группе
            List<string> listNumericOrStringGrades = new List<string>();
            listNumericOrStringGrades = dataBase.GetGroupGradesForAllSubjectAllSemesters(groupdId);

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
            float groupGPA = 0; // средний балл отметок студентов
            if (listNumericGrades.Count != 0)
            {
                // высчитываем средний балл всех студентов группы по всем предметам за все семестры
                groupGPA = (float)Math.Round(listNumericGrades.Sum() / listNumericGrades.Count(), 1);
            }
            return groupGPA;
        }
        public static float GetStudentGPA(int studentId)
        {
            // получаем отметки студентА в группе
            List<string> listNumericOrStringGradesForOneStudent = new List<string>(); // список числовых отметок
            listNumericOrStringGradesForOneStudent = dataBase.GetStudentGradesForAllSubjectAllSemesters(studentId);

            List<float> listNumericGradesForOneStudent = new List<float>(); // список числовых отметок

            // выводим отметки в лейбл для числовых отметок и в лейбл для строковых         
            for (int i = 0; i < listNumericOrStringGradesForOneStudent.Count(); i++) // проходимся по всем отметкам в списке
            {
                int numericGrade; // конвертированная в численный тип отметка
                bool isNumber = int.TryParse(listNumericOrStringGradesForOneStudent[i], out numericGrade);
                if (isNumber) // если отметка числовая, то добавляем ее в список числовых отметок
                {
                    listNumericGradesForOneStudent.Add(numericGrade);
                }
            }
            // высчитываем средний балл студентА по всем предметам за все семестры
            float studentGPA = 0;
            if (listNumericGradesForOneStudent.Count != 0)
            {
                studentGPA = (float)Math.Round(listNumericGradesForOneStudent.Sum() / listNumericGradesForOneStudent.Count(), 1);
            }
            return studentGPA;
        }
    }
}
