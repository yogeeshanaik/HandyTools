using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseCatalogReader
{
    public class ProcParameter : Parameter
    {
        public ProcParameter(SqlDataReader reader)
        {
            object obj = reader["Ordinal"];
            Ordinal = (int)(short)obj;
            Name = reader["Name"] as string;
            Type = ToSqlDbType(reader["Type"] as string);
            obj = reader["Length"];
            Length = (int)(short)obj;
            Direction = ((int)reader["Output"] == 0) ? ParameterDirection.Input : ParameterDirection.Output;
        }

        private ParameterDirection direction = ParameterDirection.Input;

        public ParameterDirection Direction
        {
            get { return this.direction; }
            set { this.direction = value; }
        }
    }

    public enum ExecuteType
    {
        NonQuery,
        Scalar,
        Reader,
        XmlReader,
    }

    public class SqlStoredProcedure : DatabaseCatalog
    {
        override public string CommandText
        {
            get
            {
                return @"
SELECT
    name
FROM
    dbo.sysobjects
WHERE
    xtype = 'P' and category = 0
";
            }
        }

        private string format = @"
SELECT
    c.colorder as Ordinal,
    c.name as Name,
    t.name as Type,
    c.length as Length,
    c.isoutparam as Output
FROM
    dbo.sysobjects o
    INNER JOIN dbo.syscolumns c ON o.id = c.id
    INNER JOIN dbo.systypes t ON c.xtype = t.xtype and c.xusertype = t.xusertype
WHERE
    o.name = '{0}'";

        private string[] procedureNames;

        public SqlStoredProcedure()
        {
        }

        public SqlStoredProcedure(string name, ExecuteType executeType)
        {
            this.name = name.Replace(" ", "_");
            this.executeType = executeType;
        }

        private string name;

        public string Name
        {
            get { return this.name; }
        }

        private ExecuteType executeType = ExecuteType.NonQuery;

        public ExecuteType ExecuteType
        {
            get { return this.executeType; }
            set { this.executeType = value; }
        }

        public void Load(SqlConnection connection)
        {
            string cmdText = string.Format(this.format, this.name);

            SqlCommand cmd = new SqlCommand(cmdText, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            using (reader)
            {
                ArrayList list = new ArrayList();
                while (reader.Read())
                    list.Add(new ProcParameter(reader));

                list.Sort(new Comparer());
                this.parameters = (ProcParameter[])list.ToArray(typeof(ProcParameter));
            }
        }

        private ProcParameter[] parameters;

        public ProcParameter[] GetParameters()
        {
            return this.parameters;
        }

        private class Comparer : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                ProcParameter param1 = obj1 as ProcParameter;
                ProcParameter param2 = obj2 as ProcParameter;
                if (param1.Ordinal > param2.Ordinal)
                    return 1;
                if (param1.Ordinal < param2.Ordinal)
                    return -1;

                return 0;
            }
        }

        private void RunDialog()
        {
            ProcDialog dlg = new ProcDialog();
            dlg.CheckedListBox.Items.AddRange(this.procedureNames);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArrayList list = new ArrayList();
                foreach (object obj in dlg.CheckedListBox.CheckedItems)
                    list.Add(obj);
                this.procedureNames = (string[])list.ToArray(typeof(string));
            }
            else
                this.procedureNames = new string[0];
        }

        public SqlStoredProcedure[] GetStoredProcedures()
        {
            if (base.ConnectionString == null)
                return new SqlStoredProcedure[0];

            SqlConnection connection = new SqlConnection(base.ConnectionString);
            connection.Open();
            using (connection)
            {
                ArrayList list = new ArrayList();
                this.procedureNames = GetStoredProcedureNames(connection);
                if (this.procedureNames.Length == 0)
                    return new SqlStoredProcedure[0];

                foreach (string name in this.procedureNames)
                    list.Add(name + " (Non-Query)");
                this.procedureNames = (string[])list.ToArray(typeof(string));

                // start a separate thread because we want the GUI to run in a STA
                // Thread thread = new Thread(new ThreadStart(this.RunDialog));
                // thread.ApartmentState = ApartmentState.STA;
                // thread.Start();
                // thread.Join();

                RunDialog();

                list.Clear();
                foreach (string name in this.procedureNames)
                {
                    string[] split = name.Split(" ".ToCharArray());
                    switch (split[1].Trim())
                    {
                        case "(Non-Query)":
                            list.Add(new SqlStoredProcedure(split[0], ExecuteType.NonQuery));
                            break;

                        case "(Scalar)":
                            list.Add(new SqlStoredProcedure(split[0], ExecuteType.Scalar));
                            break;

                        case "(Reader)":
                            list.Add(new SqlStoredProcedure(split[0], ExecuteType.Reader));
                            break;

                        case "(XmlReader)":
                            list.Add(new SqlStoredProcedure(split[0], ExecuteType.XmlReader));
                            break;
                    }
                }

                SqlStoredProcedure[] StoredProcedures = (SqlStoredProcedure[])list.ToArray(typeof(SqlStoredProcedure));
                foreach (SqlStoredProcedure proc in StoredProcedures)
                    proc.Load(connection);

                return StoredProcedures;
            }
        }

        private string[] GetStoredProcedureNames(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand(this.CommandText, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            using (reader)
            {
                ArrayList list = new ArrayList();
                while (reader.Read())
                    list.Add(reader[0]);

                return (string[])list.ToArray(typeof(string));
            }
        }
    }

    /*
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class DatabaseCatalog
    {
        private string connectionString = "";

        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            }

            set
            {
                if (value == null || value.Length == 0)
                {
                    this.connectionString = "";
                    return;
                }

                this.connectionString = value;
                string temp = this.connectionString.ToUpper();

                int n1 = temp.IndexOf("PROVIDER");
                int n2;
                if (n1 != -1)
                {
                    n2 = temp.IndexOf(";", n1);
                    this.connectionString = temp.Substring(n2 + 1);
                }

                n1 = temp.IndexOf("INITIAL CATALOG");
                if (n1 == -1)
                    n1 = temp.IndexOf("DATABASE");
                if (n1 == -1)
                    throw new DatabaseCatalogReaderException("Database name missing");

                n2 = temp.IndexOf(";", n1);
                if (n2 == -1)
                    temp = temp.Substring(n1);
                else
                    temp = temp.Substring(n1, n2 - n1);

                string[] split = temp.Split("=".ToCharArray());

                this.name = split[1].Trim();
            }
        }

        private string DialogGetConnectionString()
        {
                    //Using the 'Add Reference' dialog box, reference COM libraries
                    //    Microsoft OLE DB Service Component 1.0 Type Library
                    //    Microsoft ActiveX Data Object 2.7 Library

                    //    Provide=SQLOLEDB.1

      //Reference DataLinks
      //NOTE: Reference
      //      C:\Program Files\Common Files\System\Ole DB\OLEDB32.DLL
      //      (Was MSDASC.dll)
      //SEE:
      //   http://support.microsoft.com:80/support/kb/articles/Q225/1/32.asp

            //DataLinks dlg = new DataLinks();
            ////ADODB._Connection connection = dlg.PromptNew() as ADODB._Connection;

            //ADODB._Connection connection = new ADODB.ConnectionClass();
            //connection.ConnectionString = "Provider=SQLOLEDB.1";
            //object obj = connection;
            //if (dlg.PromptEdit(ref obj))
            //    //if(connection != null)
            //    return connection.ConnectionString;
            return @"Data Source=(localdb)\Projects; Initial Catalog=Product.Database; Integrated Security=True; User Id=sa; Password=ikya1510;";
        }

        private string cmdText = @"
SELECT
    name
FROM
    dbo.sysobjects
WHERE
    xtype = 'P' and category = 0
";

        public DatabaseCatalog()
        {
            ConnectionString = DialogGetConnectionString();
        }

        public DatabaseCatalog(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private string name = "Database";

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public bool IsConnected()
        {
            return (this.connectionString.Length > 0);
        }

        private string[] procedureNames;
    }
    */
}