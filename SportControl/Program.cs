using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        static public SQLiteConnection connection;
        static public String DBName = "db.sqlite";
        static public SQLiteCommand command;


        [STAThread]
        static void Main()
        {
            CheckDB();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        static public bool CheckDB()
        {
            if (ConnectDB())
            {
                command = new SQLiteCommand(connection)
                {
                    CommandText = "CREATE TABLE IF NOT EXISTS [Person]([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, [name] TEXT, [family] TEXT, [number] INTEGER, [tid1] TEXT, [tid2] TEXT, [age] INTEGER);"
                };
                command.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool ConnectDB()
        {
            try
            {
                connection = new SQLiteConnection("Data Source=" + DBName + ";Version=3; FailIfMissing=False");
                connection.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
                return false;
            }
        }
    }
}
