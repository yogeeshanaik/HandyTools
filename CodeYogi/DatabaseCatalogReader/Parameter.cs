using System;
using System.Data;
using System.Linq;

namespace DatabaseCatalogReader
{
    public abstract class Parameter
    {
        #region Properties

        public int Ordinal { get; set; }

        public string Name { get; set; }

        public SqlDbType Type { get; set; }

        public int Length { get; set; }

        public string DefaultValue { get; set; }

        private static Lazy<SqlDbType[]> _someVariable = new Lazy<SqlDbType[]>(() => GetSqlDbTypes());
        public static SqlDbType[] SqlDbTypes
        {
            get { return _someVariable.Value; }
        }
        #endregion Properties

        #region private properties

        private static SqlDbType[] GetSqlDbTypes()
        {
            return System.Enum.GetValues(typeof(SqlDbType))
                        .Cast<SqlDbType>()
                        .ToArray();
        }

        private static string GetClrType(SqlDbType sqlType, bool markNullable)
        {
            switch (sqlType)
            {
                case SqlDbType.Binary:
                case SqlDbType.Image:
                case SqlDbType.Timestamp:
                case SqlDbType.VarBinary:
                    return typeof(byte[]).Name;

                case SqlDbType.Char:
                case SqlDbType.NChar:
                case SqlDbType.NText:
                case SqlDbType.NVarChar:
                case SqlDbType.Text:
                case SqlDbType.VarChar:
                case SqlDbType.Xml:
                    return typeof(string).Name;

                case SqlDbType.Variant:
                case SqlDbType.Udt:
                    return typeof(object).Name;

                case SqlDbType.Structured:
                    return typeof(DataTable).Name;

                case SqlDbType.BigInt:
                    return markNullable ? typeof(long).Name+"?" : typeof(long).Name;

                case SqlDbType.Bit:
                    return markNullable ? typeof(bool).Name + "?" : typeof(bool).Name;

                case SqlDbType.DateTime:
                case SqlDbType.SmallDateTime:
                case SqlDbType.Date:
                case SqlDbType.Time:
                case SqlDbType.DateTime2:
                    return markNullable ? typeof(DateTime).Name + "?" : typeof(DateTime).Name;

                case SqlDbType.Decimal:
                case SqlDbType.Money:
                case SqlDbType.SmallMoney:
                    return markNullable ? typeof(decimal).Name + "?" : typeof(decimal).Name;

                case SqlDbType.Float:
                    return markNullable ? typeof(double).Name + "?" : typeof(double).Name;

                case SqlDbType.Int:
                    return markNullable ? typeof(int).Name + "?" : typeof(int).Name;

                case SqlDbType.Real:
                    return markNullable ? typeof(float).Name + "?" : typeof(float).Name;

                case SqlDbType.UniqueIdentifier:
                    return markNullable ? typeof(Guid).Name + "?" : typeof(Guid).Name;

                case SqlDbType.SmallInt:
                    return markNullable ? typeof(short).Name + "?" : typeof(short).Name;

                case SqlDbType.TinyInt:
                    return markNullable ? typeof(byte).Name + "?" : typeof(byte).Name;

                case SqlDbType.DateTimeOffset:
                    return markNullable ? typeof(DateTimeOffset).Name + "?" : typeof(DateTimeOffset).Name;

                default:
                    throw new ArgumentOutOfRangeException("sqlType");
            }
        }
        #endregion

        #region public methods

        public static SqlDbType ToSqlDbType(string type)
        {
            var matches = System.Array.FindAll(SqlDbTypes, s => s.Equals((SqlDbType)System.Enum.Parse(typeof(SqlDbType), type, true)));

            if (matches.Length > 0)
                return matches.FirstOrDefault();
            else
                throw new DatabaseCatalogReaderException(string.Format("Unknown type {0}", type));
        }

        public string ToNetType(bool markNullable = false)
        {
            return GetClrType(this.Type, markNullable);
        }


        public string ToNetType2()
        {
            switch (this.Type)
            {
                case SqlDbType.BigInt: return "System.In64";
                case SqlDbType.Binary: return "System.Byte[]";
                case SqlDbType.Bit: return "System.Boolean";
                case SqlDbType.Char: return "System.String";
                case SqlDbType.DateTime: return "System.DateTime";
                case SqlDbType.Decimal: return "System.Decimal";
                case SqlDbType.Float: return "System.Double";
                case SqlDbType.Image: return "System.Byte[]";
                case SqlDbType.Int: return "System.Int32";
                case SqlDbType.Money: return "System.Decimal";
                case SqlDbType.NChar: return "System.String";
                case SqlDbType.NText: return "System.String";
                case SqlDbType.NVarChar: return "System.String";
                case SqlDbType.Real: return "System.Float";
                case SqlDbType.SmallDateTime: return "System.DateTime";
                case SqlDbType.SmallInt: return "System.Short";
                case SqlDbType.SmallMoney: return "System.Decimal";
                case SqlDbType.Text: return "System.String";
                case SqlDbType.Timestamp: return "System.Byte[]";
                case SqlDbType.TinyInt: return "System.Byte";
                case SqlDbType.UniqueIdentifier: return "System.Guid";
                case SqlDbType.VarBinary: return "System.Byte[]";
                case SqlDbType.VarChar: return "System.String";
                case SqlDbType.Variant: return "System.Object";
                default:
                    return "";
            }
        }

        #endregion public methods
    }
}