using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;

namespace Apotik.Model
{
    class Database
    {
        public struct Schema
        {
            public Type baseType;
            public Type type;
            public string tableName;
            public IEnumerable<BaseModel.ColumnAccessor> columns;
            public IEnumerable<BaseModel.ReferenceColumnAccessor> refColumns;

            public BaseModel.ColumnAccessor GetPrimaryKey()
            {
                return columns.Where(p => p.field.PrimaryKey == true).First();
            }

            public string GetReferenceColumnName()
            {
                return string.Format("{0}_{1}", tableName, GetPrimaryKey().field.Name);
            }
        }

        private SQLiteConnection connection;
        private Dictionary<string, Schema> schemas = new Dictionary<string, Schema>();

        public Database(string filename)
        {
            connection = new SQLiteConnection("Data Source=" + filename +";Version=3");
            connection.Open();
        }

        public SQLiteConnection Connection
        {
            get { return connection; }
        }

        public SQLColumn Column(string propertyName)
        {
            return new SQLColumn(propertyName);
        }

        public SQLColumn Column(int index, string propertyName)
        {
            return new SQLColumn(propertyName, index);
        }

        public SQLCondition Like(SQLColumn column, string condition)
        {
            return new SQLCondition(SQLCondition.Operator.Like, column, new SQLString(condition));
        }

        public int Save<T>(T model) where T: BaseModel
        {
            var type = model.GetType();
            var typeSignature = GetTypeSignature(type);

            if (!schemas.ContainsKey(typeSignature))
                throw new NotImplementedException(string.Format("{0} is no registered. " +
                    "Register using Database.RegisterSchema() method."));

            var schema = schemas[typeSignature];
            var baseType = schema.baseType;
            var tableName = schema.tableName;

            var columns = schema.columns.Where(f => !f.field.AutoIncrement);
            var refColumns = schema.refColumns;
            var allColumns = columns.Select(f => f.field.Name)
                .Concat(refColumns.Select(f => GetSchema(f.reference.Type).GetReferenceColumnName()));

            var sql = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName,
                string.Join(",", allColumns),
                string.Join(",", allColumns.Select(c => "$" + c)));

            var command = new SQLiteCommand(sql, connection);

            foreach (var col in columns)
            {
                command.Parameters.AddWithValue("$" + col.field.Name, col.propertyInfo.GetValue(model));
            }

            foreach (var col in refColumns)
            {
                var refObj = col.propertyInfo.GetValue(model);
                var pk = BaseModel.GetPrimaryKey(refObj.GetType().BaseType);
                command.Parameters.AddWithValue("$" + GetSchema(col.reference.Type).GetReferenceColumnName(),
                    pk.propertyInfo.GetValue(refObj));
            }

            var pkProp = schema.GetPrimaryKey().propertyInfo;
            var pkName = pkProp.Name;

            var transaction = connection.BeginTransaction();
            var ret = command.ExecuteNonQuery();
            var newModel = Query2<T>().OrderBy(Column(pkName), false).Limit(1).Execute().First();
            var newId = pkProp.GetMethod.Invoke(newModel, null);
            pkProp.SetMethod.Invoke(model, new[] { newId });
            transaction.Commit();
            return ret;
        }

        public int Save<T>(IEnumerable<T> models) where T: BaseModel
        {
            var retVal = 0;
            foreach (var m in models)
            {
                retVal += Save(m);
            }
            return retVal;
        }

        public int Update<T>(T model) where T: BaseModel
        {
            var type = typeof(T);
            var schema = GetSchema(type);

            var columns = schema.columns.Where(f => !f.field.AutoIncrement);
            var refColumns = schema.refColumns;
            var allColumns = columns.Select(f => f.field.Name)
                .Concat(refColumns.Select(f => GetSchema(f.reference.Type).GetReferenceColumnName()));
            var sqlColumnSet = string.Join(",", allColumns.Select(f => string.Format("{0} = ${0}", f)));

            var sqlColumnId = schema.columns.Where(f => f.field.PrimaryKey).First();
            var whereClause = string.Format("{0} = ${0}", sqlColumnId.field.Name);

            var sql = string.Format("UPDATE {0} SET {1} WHERE {2}", schema.tableName,
                sqlColumnSet, whereClause);
            var command = new SQLiteCommand(sql, connection);

            foreach (var c in schema.columns)
            {
                command.Parameters.AddWithValue("$" + c.field.Name, c.propertyInfo.GetValue(model));
            }

            foreach (var col in refColumns)
            {
                var refObj = col.propertyInfo.GetValue(model);
                var pk = BaseModel.GetPrimaryKey(refObj.GetType().BaseType);
                command.Parameters.AddWithValue("$" + GetSchema(col.reference.Type).GetReferenceColumnName(),
                    pk.propertyInfo.GetValue(refObj));
            }

            return command.ExecuteNonQuery();
        }

        public IEnumerable<T> Query<T>(string whereClause = null) where T: new()
        {
            var type = typeof(T);
            var tableName = BaseModel.GetTableName(type);
            var columns = BaseModel.GetColumns(type);
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

        public SQLQuery<T> Query2<T>() where T: BaseModel
        {
            return new SQLQuery<T>(this);
        }

        public bool RegisterSchema<T>() where T: BaseModel
        {
            var baseType = typeof(T);
            var typeSignature = GetTypeSignature(baseType);

            if (schemas.ContainsKey(typeSignature))
                return true;

            var schema = new Schema();
            schema.baseType = baseType;
            schema.type = BaseModel.CreateType(typeSignature, baseType);
            schema.tableName = BaseModel.GetTableName(baseType);
            schema.columns = BaseModel.GetColumns(baseType);
            schema.refColumns = BaseModel.GetReferenceColumns(baseType);

            var fieldsSql = BaseModel.CreateFieldsSql(baseType);
            var sql = string.Format("CREATE TABLE IF NOT EXISTS {0} ({1})", schema.tableName, fieldsSql);
            var command = new SQLiteCommand(sql, connection);

            schemas[typeSignature] = schema;

            command.ExecuteNonQuery();

            return true;
        }

        public Schema GetSchema(Type type)
        {
            if (schemas.ContainsKey(GetTypeSignature(type)))
                return schemas[GetTypeSignature(type)];
            else
                return schemas[type.Name];
        }

        private string GetTypeSignature(Type baseType)
        {
            return baseType.Name + "Impl";
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
            if (!db.RegisterSchema<Model.Distributor>())
                return false;

            if (!db.RegisterSchema<Model.Dokter>())
                return false;

            if (!db.RegisterSchema<Model.Obat>())
                return false;

            if (!db.RegisterSchema<Model.User>())
                return false;

            if (!db.RegisterSchema<Model.Penjualan>())
                return false;

            if (!db.RegisterSchema<Model.DetailJual>())
                return false;

            return true;
        }
        #endregion
    }

    public class BaseModel : System.ComponentModel.INotifyPropertyChanged
    {
        #region System.ComponentModel.INotifyPropertyChanged implementation
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        #endregion

        #region Table metadata access methods
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

        public static string CreateFieldsSql(Type refl)
        {
            // fields
            var columnsSql = refl.GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .Where(p => p.GetCustomAttributes(typeof(Attributes.Field), false).Length > 0)
                .Select(p =>
                {
                    var fieldAttr = (Attributes.Field)p.GetCustomAttributes(
                        typeof(Attributes.Field), false)[0];

                    var sql = fieldAttr.Name;
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

            // constraint references
            var constraintSql = refl.GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .Where(p => p.GetCustomAttributes(typeof(Attributes.Reference), false).Length > 0)
                .Select(p =>
                {
                    var refAttr = (Attributes.Reference)p.GetCustomAttributes(
                        typeof(Attributes.Reference), false)[0];

                    var refTableName = GetTableName(refAttr.Type);

                    var refPrimaryKey = GetPrimaryKey(refAttr.Type);

                    var columnType = "TEXT";
                    if (refPrimaryKey.propertyInfo.GetMethod.ReturnType.ToString().StartsWith("System.Int"))
                        columnType = "INTEGER";

                    var refColumnName = refPrimaryKey.field.Name;

                    var columnName = GetReferenceColumnName(refAttr);

                    return string.Format("{0} {1} REFERENCES {2}({3}) ON UPDATE CASCADE",
                        columnName,
                        columnType,
                        refTableName,
                        refColumnName);
                });

            return string.Join(",\n", columnsSql.Concat(constraintSql));
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

        public struct ReferenceColumnAccessor
        {
            public Attributes.Reference reference;
            public PropertyInfo propertyInfo;

            public ReferenceColumnAccessor(Attributes.Reference reference, PropertyInfo info)
            {
                this.reference = reference;
                this.propertyInfo = info;
            }
        }

        public static IEnumerable<ColumnAccessor> GetColumns(Type type)
        {
            var columns = type.GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .Where(p => p.GetCustomAttributes(typeof(Attributes.Field), false).Length > 0)
                .Select(p =>
                {
                    var fieldAttr = (Attributes.Field)p.GetCustomAttributes(
                        typeof(Attributes.Field), false)[0];
                    return new ColumnAccessor(fieldAttr, p);
                });

            return columns;
        }

        public static IEnumerable<ReferenceColumnAccessor> GetReferenceColumns(Type type)
        {
            return type.GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .Where(p => p.GetCustomAttributes(typeof(Attributes.Reference), false).Length > 0)
                .Select(p =>
                {
                    var refAttr = (Attributes.Reference)p.GetCustomAttributes(
                        typeof(Attributes.Reference), false)[0];
                    return new ReferenceColumnAccessor(refAttr, p);
                });
        }

        public static ColumnAccessor GetPrimaryKey(Type type)
        {
            return type.GetProperties()
                .Where(p =>
                {
                    if (p.GetCustomAttributes(typeof(Attributes.Field), false).Length == 0)
                        return false;

                    var fieldAttr = (Attributes.Field)p.GetCustomAttributes(typeof(Attributes.Field),
                        false)[0];

                    if (fieldAttr.PrimaryKey != true)
                        return false;

                    return true;
                })
                .Select(p =>
                {
                    var fieldAttr = (Attributes.Field)p.GetCustomAttributes(typeof(Attributes.Field),
                        false)[0];

                    return new ColumnAccessor(fieldAttr, p);
                })
                .First();
        }

        public static string GetReferenceColumnName(Attributes.Reference reference)
        {
            return string.Format("{0}_{1}", GetTableName(reference.Type),
                GetPrimaryKey(reference.Type).field.Name);
        }

        public static string GetColumnName(Type type, string propertyName)
        {
            var propertyInfo = type.GetProperty(propertyName);
            var attribute = (Attributes.Field) propertyInfo.GetCustomAttributes(typeof(Attributes.Field),
                false)[0];
            return attribute.Name;
        }
        #endregion

        #region Concrete type creation
        private static Dictionary<string, Type> types = new Dictionary<string, Type>();

        public static T New<T>() where T : BaseModel
        {
            var parentType = typeof(T);
            var typeSignature = parentType.Name + "Impl";

            if (!types.ContainsKey(typeSignature))
            {
                var typeBuilder = CreateType(typeSignature, parentType);

                var constructorBuilder = typeBuilder.DefineDefaultConstructor(
                    MethodAttributes.Public |
                    MethodAttributes.SpecialName |
                    MethodAttributes.RTSpecialName);

                foreach (var p in GetColumns(parentType))
                {
                    CreateProperty(typeBuilder, p.propertyInfo.Name, p.propertyInfo.GetMethod.ReturnType);
                }

                foreach (var p in GetReferenceColumns(parentType))
                {
                    CreateProperty(typeBuilder, p.propertyInfo.Name, p.propertyInfo.GetMethod.ReturnType);
                }

                types[typeSignature] = typeBuilder.CreateType();
            }

            var type = types[typeSignature];
            return (T)Activator.CreateInstance(type);
        }

        public static TypeBuilder CreateType(string typeSignature, Type parent)
        {
            var assemblyName = new AssemblyName(typeSignature);
            var assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                AssemblyBuilderAccess.Run);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");
            return moduleBuilder.DefineType(typeSignature,
                TypeAttributes.Public |
                TypeAttributes.Class |
                TypeAttributes.AutoClass |
                TypeAttributes.AnsiClass |
                TypeAttributes.BeforeFieldInit |
                TypeAttributes.AutoLayout,
                parent);
        }

        public static void CreateProperty(TypeBuilder typeBuilder, string propertyName, Type propertyType)
        {
            var propertyBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault,
                propertyType, null);

            // Property get method
            var getMethodBuilder = typeBuilder.DefineMethod("get_" + propertyName,
                MethodAttributes.Public |
                MethodAttributes.Virtual |
                MethodAttributes.SpecialName |
                MethodAttributes.HideBySig,
                propertyType, Type.EmptyTypes);
            var getILGen = getMethodBuilder.GetILGenerator();

            // Call base type get property
            var baseType = typeBuilder.BaseType;
            var baseGetMethod = baseType.GetProperty(propertyName).GetMethod;

            getILGen.Emit(OpCodes.Ldarg_0);
            getILGen.Emit(OpCodes.Call, baseGetMethod);
            getILGen.Emit(OpCodes.Ret);

            // Property set method
            var setMethodBuilder = typeBuilder.DefineMethod("set_" + propertyName,
                MethodAttributes.Public |
                MethodAttributes.Virtual |
                MethodAttributes.SpecialName |
                MethodAttributes.HideBySig,
                null, new[] { propertyType });
            var setILGen = setMethodBuilder.GetILGenerator();

            var modifyProperty = setILGen.DefineLabel();
            var exitSet = setILGen.DefineLabel();

            setILGen.MarkLabel(modifyProperty);

            // Call base type set property
            var baseSetMethod = baseType.GetProperty(propertyName).SetMethod;

            setILGen.Emit(OpCodes.Ldarg_0);
            setILGen.Emit(OpCodes.Ldarg_1);
            setILGen.Emit(OpCodes.Call, baseSetMethod);

            // Call BaseModel.InvokePropertyChanged
            var propertyChangedEventArgsConstructor = typeof(System.ComponentModel.PropertyChangedEventArgs)
                .GetConstructor(new[] { typeof(string) });
            var invokePropertyChanged = typeof(BaseModel).GetMethod("InvokePropertyChanged",
                new[] { typeof(System.ComponentModel.PropertyChangedEventArgs) });

            setILGen.Emit(OpCodes.Ldarg_0);
            setILGen.Emit(OpCodes.Ldstr, propertyName);
            setILGen.Emit(OpCodes.Newobj, propertyChangedEventArgsConstructor);
            setILGen.Emit(OpCodes.Call, invokePropertyChanged);

            setILGen.MarkLabel(exitSet);
            setILGen.Emit(OpCodes.Ret);

            propertyBuilder.SetGetMethod(getMethodBuilder);
            propertyBuilder.SetSetMethod(setMethodBuilder);
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

    class SQLCondition : ISQLSyntax
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

        public SQLCondition(Operator op, ISQLSyntax lhs, ISQLSyntax rhs)
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

    class SQLColumn : ISQLSyntax
    {
        private int index;
        private string propertyName;

        public SQLColumn(string propertyName, int index = 0)
        {
            this.index = index;
            this.propertyName = propertyName;
        }

        public string ToSqlQuery(IList<Type> model)
        {
            var type = model[index];
            if (model.Count > 1)
                return string.Format("{0}.{1}", BaseModel.GetTableName(type),
                    BaseModel.GetColumnName(type, propertyName));
            else
                return string.Format("{0}", BaseModel.GetColumnName(type, propertyName));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return index.GetHashCode() + propertyName.GetHashCode();
        }

        public static SQLCondition operator==(SQLColumn column, string value)
        {
            return new SQLCondition(SQLCondition.Operator.Equals, column, new SQLString(value));
        }

        public static SQLCondition operator!=(SQLColumn column, string value)
        {
            return new SQLCondition(SQLCondition.Operator.NotEquals, column, new SQLString(value));
        }

        public static SQLCondition operator<(SQLColumn column, string value)
        {
            return new SQLCondition(SQLCondition.Operator.LessThan, column, new SQLString(value));
        }

        public static SQLCondition operator>(SQLColumn column, string value)
        {
            return new SQLCondition(SQLCondition.Operator.GreaterThan, column, new SQLString(value));
        }

        public static SQLCondition operator<=(SQLColumn column, string value)
        {
            return new SQLCondition(SQLCondition.Operator.LessThanOrEquals, column, new SQLString(value));
        }
        public static SQLCondition operator>=(SQLColumn column, string value)
        {
            return new SQLCondition(SQLCondition.Operator.GreaterThanOrEquals, column, new SQLString(value));
        }
    }

    class SQLQuery<T> where T: BaseModel
    {
        private Database db;
        private SQLCondition condition;

        private bool order = false;
        private SQLColumn orderBy;
        private bool orderAscending = true;

        private bool limit = false;
        private int limitStart = 0;
        private int limitCount = 1;

        public SQLQuery(Database db)
        {
            this.db = db;
        }

        public SQLQuery<T> Where(SQLCondition condition)
        {
            this.condition = condition;

            return this;
        }

        public SQLQuery<T> Where(bool condition)
        {
            return this;
        }

        public SQLQuery<T> OrderBy(SQLColumn column, bool ascending = true)
        {
            order = true;
            orderBy = column;
            orderAscending = ascending;

            return this;
        }

        public SQLQuery<T> Limit(int count)
        {
            limit = true;
            limitStart = 0;
            limitCount = count;

            return this;
        }

        public SQLQuery<T> Limit(int start, int count)
        {
            limit = true;
            limitStart = start;
            limitCount = count;

            return this;
        }

        public IList<T> Execute()
        {
            var type = typeof(T);
            var schema = db.GetSchema(type);
            var command = new SQLiteCommand(ToSqlQuery(), db.Connection);
            var reader = command.ExecuteReader();
            var result = new List<T>();
            while (reader.Read())
            {
                var i = 0;
                var t = BaseModel.New<T>();
                foreach (var c in schema.columns)
                {
                    var columnType = c.GetColumnType();
                    if (columnType == "int")
                    {
                        var value = reader.GetInt32(i);
                        c.propertyInfo.SetValue(t, value);
                    }
                    else if (columnType == "string")
                    {
                        var value = reader.GetString(i);
                        c.propertyInfo.SetValue(t, value);
                    }
                    ++i;
                }
                result.Add(t);
            }
            return result;
        }

        public string ToSqlQuery()
        {
            var type = typeof(T);
            var schema = db.GetSchema(type);
            var columnName = string.Join(",", schema.columns.Select(f => f.field.Name));
            var sql = string.Format("SELECT {1} FROM {0}", schema.tableName, columnName);
            if (condition != null)
                sql += string.Format(" WHERE {0}", condition.ToSqlQuery(new[] { type }));

            if (order)
            {
                sql += string.Format(" ORDER BY {0} {1}", orderBy.ToSqlQuery(new[] { type }),
                    orderAscending ? "ASC" : "DESC");
            }

            if (limit)
            {
                sql += string.Format(" LIMIT {0},{1}", limitStart, limitCount);
            }

            return sql;
        }
    }
}
