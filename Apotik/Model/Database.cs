using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections;

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

        public Column Column(string propertyName)
        {
            return new Column(propertyName);
        }

        public Column Column(int index, string propertyName)
        {
            return new Column(propertyName, index);
        }

        public Condition Like(Column column, string condition)
        {
            return new Condition(Condition.Operator.Like, column, new SQLString(condition));
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

        public int Update(object model)
        {
            var type = model.GetType();
            var tableName = GetTableName(type);
            var columns = GetColumns(type);
            var writableColumns = columns.Where(f => !f.field.AutoIncrement);
            var sqlColumnSet = string.Join(",", writableColumns.Select(
                f => string.Format("{0} = ${0}", f.field.Name)));
            var sqlColumnId = columns.Where(f => f.field.PrimaryKey).FirstOrDefault();
            var whereClause = string.Format("{0} = ${0}", sqlColumnId.field.Name);
            var sql = string.Format("UPDATE {0} SET {1} WHERE {2}", tableName, sqlColumnSet, whereClause);

            var command = new SQLiteCommand(sql, connection);
            foreach (var col in columns)
            {
                command.Parameters.AddWithValue("$" + col.field.Name, col.propertyInfo.GetValue(model));
            }

            return command.ExecuteNonQuery();
        }

        public IEnumerable<T> Query<T>(string whereClause = null) where T: new()
        {
            var type = typeof(T);
            var tableName = GetTableName(type);
            var columns = GetColumns(type);
            var sql = string.Format("SELECT * FROM {0}", tableName);
            if (whereClause != null)
                sql += string.Format(" WHERE {0}", whereClause);
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

        public Query<T> Query2<T>() where T: new()
        {
            return new Query<T>(this);
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
            if (!InitSchemaFromTable(db, typeof(Model.Distributor)))
                return false;

            if (!InitSchemaFromTable(db, typeof(Model.Dokter)))
                return false;

            if (!InitSchemaFromTable(db, typeof(Model.Obat)))
                return false;

            if (!InitSchemaFromTable(db, typeof(Model.User)))
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

        public static string GetColumnName(Type type, string propertyName)
        {
            var propertyInfo = type.GetProperty(propertyName);
            var attribute = (Attributes.Field) propertyInfo.GetCustomAttributes(typeof(Attributes.Field),
                false)[0];
            return attribute.Name;
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

    interface ISQLSyntax
    {
        string ToSqlQuery(IList<Type> model = null);
    }

    class SQLString : ISQLSyntax
    {
        private string str;

        public SQLString(string str)
        {
            this.str = str;
        }

        public string ToSqlQuery(IList<Type> model = null)
        {
            return string.Format("\"{0}\"", str);
        }
    }

    class Condition : ISQLSyntax
    {
        public enum Operator
        {
            And,
            Or,
            Equals,
            NotEquals,
            GreaterThan,
            GreaterThanOrEquals,
            LessThan,
            LessThanOrEquals,
            Like,
        }

        private Operator op;
        private ISQLSyntax lhs;
        private ISQLSyntax rhs;

        public Condition(Operator op, ISQLSyntax lhs, ISQLSyntax rhs)
        {
            this.op = op;
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public string ToSqlQuery(IList<Type> model = null)
        {
            string op;
            switch (this.op)
            {
                case Operator.Equals: op = "="; break;
                case Operator.NotEquals: op = "<>"; break;
                case Operator.Like: op = "LIKE"; break;
                default: throw new NotImplementedException("Unknown sql operator " + this.op.ToString());
            }
            return string.Format("({0} {1} {2})", lhs.ToSqlQuery(model), op, rhs.ToSqlQuery(model));
        }
    }

    class Column : ISQLSyntax
    {
        private int index;
        private string propertyName;

        public Column(string propertyName, int index = 0)
        {
            this.index = index;
            this.propertyName = propertyName;
        }

        public string ToSqlQuery(IList<Type> model = null)
        {
            var type = model[index];
            if (model.Count > 1)
                return string.Format("{0}.{1}", Database.GetTableName(type),
                    Database.GetColumnName(type, propertyName));
            else
                return string.Format("{0}", Database.GetColumnName(type, propertyName));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return index.GetHashCode() + propertyName.GetHashCode();
        }

        public static Condition operator==(Column column, string value)
        {
            return new Condition(Condition.Operator.Equals, column, new SQLString(value));
        }

        public static Condition operator!=(Column column, string value)
        {
            return new Condition(Condition.Operator.NotEquals, column, new SQLString(value));
        }

        public static Condition operator<(Column column, string value)
        {
            return new Condition(Condition.Operator.LessThan, column, new SQLString(value));
        }

        public static Condition operator>(Column column, string value)
        {
            return new Condition(Condition.Operator.GreaterThan, column, new SQLString(value));
        }

        public static Condition operator<=(Column column, string value)
        {
            return new Condition(Condition.Operator.LessThanOrEquals, column, new SQLString(value));
        }
        public static Condition operator>=(Column column, string value)
        {
            return new Condition(Condition.Operator.GreaterThanOrEquals, column, new SQLString(value));
        }
    }

    class Query<T> where T: new()
    {
        private Database db;
        private Condition condition;

        public Query(Database db)
        {
            this.db = db;
        }

        public Query<T> Where(Condition condition)
        {
            this.condition = condition;

            return this;
        }

        public Query<T> Where(bool condition)
        {
            return this;
        }

        public IList<T> Execute()
        {
            var type = typeof(T);
            var columns = Database.GetColumns(type);
            var command = new SQLiteCommand(ToSqlQuery(), db.Connection);
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

        public string ToSqlQuery()
        {
            var type = typeof(T);
            var tableName = Database.GetTableName(type);
            var columns = Database.GetColumns(type);
            var columnName = string.Join(",", columns.Select(f => f.field.Name));
            var sql = string.Format("SELECT {1} FROM {0}", tableName, columnName);
            if (condition != null)
                sql += string.Format(" WHERE {0}", condition.ToSqlQuery(new List<Type>(){ type }));

            return sql;
        }
    }
}
