using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRating.Classes
{
    class DataBaseConnection
    {
        // поле для создания подключения к БД
        // благодаря классу SqlConnection происходят все операции с БД
        // через созданное открытое подключение

        // для того чтобы вытащить строку подключения из файла настроек нужно прописать это:
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringDatabaseStudentRating"].ConnectionString);
        // нужен класс ConfigurationManager и его свойство ConnectionStrings
        // (это словарь и по ключу мы можем получать значения
        // ключом является "ConnectionStringsDatabaseStudentRating")
        // но если не написать в конце ConnectionString, то вернется вся строка подключения
        // а у нее есть имя, сама строка подключения = путь к БД (она нам и нужна)

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                // открываем подключение к БД, иначе ничего не будет работать
                sqlConnection.Open();

                //// проверка, установилось ли подключение к БД
                //if (sqlConnection.State == ConnectionState.Open)
                //{
                //    MessageBox.Show("Подключение к БД установлено!");
                //}
            }
        }

        public void closeConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) 
            {
                sqlConnection.Close();
            }
        }

        // метод для возвращения строки подключения, нужно для того чтобы выполнять команды
        public SqlConnection getConnection() 
        { 
            return sqlConnection; 
        }
    }
}
