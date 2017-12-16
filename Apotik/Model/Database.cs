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

        public SQLiteConnection Connection
        {
            get { return connection; }
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

        public IEnumerable<T> Query<T>() where T: new()
        {
            var type = typeof(T);
            var tableName = GetTableName(type);
            var columns = GetColumns(type);
            var sql = string.Format("SELECT * FROM {0}", tableName);
            var command = new SQLiteCommand(sql, connection);
            var reader = command.ExecuteReader();
            var result = new List<T>();
            while (reader.Read())
            {
                var i = 0;
                var t = new T();
                foreach (var column in columns)
                {
                    var columnType = column.GetColumnType();
                    if (columnType == "int")
                        column.propertyInfo.SetValue(t, reader.GetInt32(i));
                    else if (columnType == "string")
                        column.propertyInfo.SetValue(t, reader.GetString(i));
                    ++i;
                }
                result.Add(t);
            }

            return result;
        }

        #region Statics
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

            if (!InitSchema(instance))
                return false;

            return true;
        }

        private static bool InitSchema(Database db)
        {
            if (!InitSchemaFromTable(db, typeof(Model.Obat)))
                return false;

            return true;
        }

        private static bool InitSchemaFromTable(Database db, Type type)
        {
            var tableName = GetTableName(type);
            var fieldsSql = CreateFieldsSql(type);
            var sql = string.Format("CREATE TABLE IF NOT EXISTS {0} ({1})", tableName, fieldsSql);
            var command = new SQLiteCommand(sql, db.connection);

            command.ExecuteNonQuery();

            return true;
        }

        public static string GetTableName(Type type)
        {
            var tableName = type.Name;
            var fields = type.GetFields();
            foreach (var field in fields)
            {
                if (field.Name == "tableName")
                    tableName = field.GetValue(null).ToString();
            }

            return tableName;
        }

        public struct ColumnAccessor
        {
            public Attributes.Field field;
            public System.Reflection.PropertyInfo propertyInfo;

            public ColumnAccessor(Attributes.Field field, System.Reflection.PropertyInfo info)
            {
                this.field = field;
                this.propertyInfo = info;
            }

            public string GetColumnType()
            {
                if (propertyInfo.GetMethod.ReturnType.ToString().StartsWith("System.Int"))
                    return "int";
                else
                    return "string";
            }
        }

        public static IEnumerable<ColumnAccessor> GetColumns(Type type)
        {
            var columns = type.GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .Where(p => p.GetCustomAttributes(typeof(Attributes.Field), false).Length > 0)
                .Select(p =>
            {
                var fieldAttr = (Attributes.Field) p.GetCustomAttributes(
                    typeof(Attributes.Field), false)[0];
                return new ColumnAccessor(fieldAttr, p);
            });

            return columns;
        }

        public static string CreateFieldsSql(Type refl)
        {
            var sql = "";

            var columnsSql = refl.GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .Where(p => p.GetCustomAttributes(typeof(Attributes.Field), false).Length > 0)
                .Select(p =>
            {
                var fieldAttr = (Attributes.Field) p.GetCustomAttributes(
                    typeof(Attributes.Field), false)[0];

                sql = fieldAttr.Name;
                if (p.GetMethod.ReturnType.ToString().StartsWith("System.Int"))
                    sql += " INTEGER";
                else
                    sql += " TEXT";
                if (fieldAttr.PrimaryKey)
                    sql += " PRIMARY KEY";
                if (fieldAttr.AutoIncrement)
                    sql += " AUTOINCREMENT";
                if (!fieldAttr.AllowNull)
                    sql += " NOT NULL";

                return sql;
            });

            return string.Join(",\n", columnsSql);
        }
        #endregion
    }
}
