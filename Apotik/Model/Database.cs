using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Apotik.Model
{
    class Database
    {
        private SQLiteConnection connection;

        private Database(string filename)
        {
            connection = new SQLiteConnection("Data Source=" + filename +";Version=3");
            connection.Open();
        }

        public int Save(object model)
        {
            var refl = model.GetType();

            // table name
            var tableName = refl.Name;
            var fields = refl.GetFields();
            foreach (var field in fields)
            {
                if (field.Name == "tableName")
                    tableName = field.GetValue(null).ToString();
            }

            // column names
            var columns = new List<Tuple<Attributes.Field, System.Reflection.PropertyInfo>>();
            var props = refl.GetProperties();
            foreach (var prop in props)
            {
                if (!prop.CanRead || !prop.CanWrite)
                    continue;

                var fieldAttrs = prop.GetCustomAttributes(typeof(Attributes.Field), false);
                if (fieldAttrs.Length == 0) continue;
                var fieldAttr = (Attributes.Field) fieldAttrs[0];

                columns.Add(Tuple.Create(fieldAttr, prop));
            }

            if (columns.Count == 0)
                return 0;

            var writableColumns = columns.Where(f => !f.Item1.AutoIncrement);
            var sqlColumnNames = string.Join(",", writableColumns.Select(v => v.Item1.Name));
            var sqlColumnValues = string.Join(",", writableColumns.Select(v => "$" + v.Item1.Name));
            var sql = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, sqlColumnNames,
                sqlColumnValues);

            // insert
            var command = new SQLiteCommand(sql, connection);
            foreach (var col in writableColumns)
            {
                var field = col.Item1;
                var prop = col.Item2;
                var value = prop.GetValue(model);
                command.Parameters.AddWithValue("$" + field.Name, prop.GetValue(model));
            }
            return command.ExecuteNonQuery();
        }

        private static Database instance = null;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                    Init();
                return instance;
            }
        }
        public static bool Init()
        {
            instance = new Database("file.sqlite");

            return true;
        }
    }
}
