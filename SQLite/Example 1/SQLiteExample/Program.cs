using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Data;

namespace SQLiteExample
{
    class Program
    {
        static SQLiteConnection connection;
        static SQLiteCommand command;
        static SQLiteTransaction transaction;

        static public bool Connect(string fileName)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=" + fileName + ";Version=3; FailIfMissing=False");
                connection.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
                return false;
            }
        }

        static void Main(string[] args)
        {
            if (Connect("firstBase.sqlite"))
            {
                Console.WriteLine("Connected");
                command = new SQLiteCommand(connection)
                {
                    CommandText = "CREATE TABLE IF NOT EXISTS [Person]([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, [name] TEXT, [family] TEXT, [age] byte);"
                };
                
                command.ExecuteNonQuery();
                Console.WriteLine("Таблица создана");
                Stopwatch sw = new Stopwatch();
                sw.Restart();

                
                command.CommandText = "INSERT INTO Person (name, family, age) VALUES (:name, :family, :age)";
                transaction = connection.BeginTransaction();//запускаем транзакцию
                try
                {
                    for (int i = 1; i < 1001; i++)
                    {
                        command.Parameters.AddWithValue("name", "Сергей");
                        command.Parameters.AddWithValue("family", "Петров");
                        command.Parameters.AddWithValue("age", i);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit(); //применяем изменения
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed);
                }
                catch
                {
                    transaction.Rollback(); //откатываем изменения, если произошла ошибка
                    throw; 
                }
            }
        }
    }
}
