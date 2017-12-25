using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Apotik
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var controller = new Controller();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home(controller));
        }

        static void InitDb()
        {
            SQLiteConnection.CreateFile("file.sqlite");
            var conn = new SQLiteConnection("Data Source=file.sqlite;Version=3");
            conn.Open();

            // Buat table
            {
                var sql = "CREATE TABLE IF NOT EXISTS tb_obat(\n" +
                    "id_obat integer PRIMARY KEY,\n" +
                    "kode_obat text NOT NULL" +
                    ")";

                var command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
            }

            // Insert
            {
                var sql = "INSERT INTO tb_obat (id_obat, kode_obat) VALUES (1, 'kode')";

                var command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
            }

            // Query
            {
                var sql = "SELECT * FROM tb_obat";

                var command = new SQLiteCommand(sql, conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("ID: " + reader["id_obat"] + ", Kode: " + reader["kode_obat"]);
                }
            }

            conn.Close();
        }
    }
}
