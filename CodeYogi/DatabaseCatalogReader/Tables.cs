using System;
using System.Collections;
using System.Data.SqlClient;

namespace DatabaseCatalogReader
{
    public class TableField : Parameter
    {
        public string QualifiedType { get; set; }

        public bool IsNullable { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsForiegnKey { get; set; }
        public bool IsUnique { get; set; }

        public string ReferencedTable { get; set; }
        public string ReferencedColumn { get; set; }


        public TableField(SqlDataReader reader)
        {
            object obj = reader["Ordinal"];
            Ordinal = (int)(short)obj;
            Name = reader["Name"] as string;
            Type = ToSqlDbType(reader["Type"] as string);
            QualifiedType = reader["QualifiedType"] as string;
            obj = reader["Length"];
            Length = (int)(short)obj;

            IsNullable = Convert.ToBoolean(reader["IsNullable"]);
            IsPrimaryKey = Convert.ToBoolean(reader["IsPrimaryKey"]);
            IsForiegnKey = Convert.ToBoolean(reader["IsForiegnKey"]);
            IsUnique = Convert.ToBoolean(reader["IsUnique"]);

            ReferencedTable = reader["ReferencedTable"] as string;
            ReferencedColumn = reader["ReferencedColumn"] as string;

            DefaultValue = reader["DefaultValue"] as string;
        }
    }

    public class SqlTable : DatabaseCatalog
    {
        #region properties

        public string Name { get; set; }

        public ExecuteType ExecuteType { get; set; }

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
                            xtype = 'U' and category = 0
                        ";
            }
        }

        #endregion

        #region variables
        private string FieldsQueryFormat
        {
            get
            {
                return @"
                        SELECT [o].[name] AS [TableName],
	                  [c].[colorder] AS [Ordinal],
	                  [c].[name] AS [Name],
	                  [t].[name] AS [Type],
	                  [t].[name]+ISNULL(CASE
					                    WHEN [t].[variable] = 1
					                    THEN '('+CAST([c].[length] AS NVARCHAR(10))+')'
					                    ELSE NULL
					                END, '') AS [QualifiedType],
	                  [c].[length] AS [Length],
	                  [c].[isnullable] AS [IsNullable],
	                  (CASE
		                  WHEN [TC].[CONSTRAINT_TYPE] = 'PRIMARY KEY'
		                  THEN 1
		                  ELSE 0
	                   END) AS [IsPrimaryKey],
	                  (CASE
		                  WHEN [TC].[CONSTRAINT_TYPE] = 'FOREIGN KEY'
		                  THEN 1
		                  ELSE 0
	                   END) AS [IsForiegnKey],
	                  (CASE
		                  WHEN [TC].[CONSTRAINT_TYPE] = 'UNIQUE'
		                  THEN 1
		                  ELSE 0
	                   END) AS [IsUnique],
	                  ISNULL([DC].[definition],'') AS [DefaultValue],
	                  OBJECT_NAME([FK].[referenced_object_id]) AS [ReferencedTable],
	                  COL_NAME([FK].[referenced_object_id], [FK].[referenced_column_id]) AS [ReferencedColumn]
                FROM   [dbo].[sysobjects] AS [o]
	                  INNER JOIN [dbo].[syscolumns] AS [c] ON [o].[id] = [c].[id]
	                  INNER JOIN [dbo].[systypes] AS [t] ON [c].[xtype] = [t].[xtype]
									                AND [c].[xusertype] = [t].[xusertype]
	                  LEFT JOIN [INFORMATION_SCHEMA].[KEY_COLUMN_USAGE] AS [CU] ON [c].[name] = [CU].[COLUMN_NAME]
													                   AND [o].[name] = [CU].[TABLE_NAME] 
	                   -- Primary Key, Forign Key & Unique Key
	                  LEFT JOIN [INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] AS [TC] ON [TC].[CONSTRAINT_NAME] = [CU].[CONSTRAINT_NAME] 
	                  -- Forign Key
	                  LEFT JOIN [sys].[foreign_key_columns] AS [FK] ON OBJECT_NAME([FK].[constraint_object_id]) = [CU].[CONSTRAINT_NAME] 
	                  -- Default Constraints
	                  LEFT JOIN [sys].[default_constraints] AS [DC] ON [C].[cdefault] = [DC].object_id
                WHERE  [o].[name] = '{0}'";
            }
        }

        private string[] tableNames;

        private TableField[] fields;

        private static string connectionSrting;
        #endregion

        #region ctor

        public SqlTable()
        {
        }

        public SqlTable(string connString)
            : base(connString)
        {
            this.ConnectionString = connString;
        }

        public SqlTable(string name, ExecuteType executeType = ExecuteType.NonQuery)
            :base(connectionSrting)
        {
            this.Name = name.Replace(" ", "_");
            this.ExecuteType = executeType;
        }

        #endregion

        #region private methods
        private string[] GetTableNames(SqlConnection connection)
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

        private void RunDialog()
        {
            ProcDialog dlg = new ProcDialog();
            dlg.CheckedListBox.Items.AddRange(this.tableNames);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArrayList list = new ArrayList();
                foreach (object obj in dlg.CheckedListBox.CheckedItems)
                    list.Add(obj);
                this.tableNames = (string[])list.ToArray(typeof(string));
            }
            else
                this.tableNames = new string[0];
        }
        #endregion

        #region public methods
        public void Load(SqlConnection connection)
        {
            string cmdText = string.Format(this.FieldsQueryFormat, this.Name);

            SqlCommand cmd = new SqlCommand(cmdText, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            using (reader)
            {
                ArrayList list = new ArrayList();
                while (reader.Read())
                    list.Add(new TableField(reader));

                list.Sort(new Comparer());
                this.fields = (TableField[])list.ToArray(typeof(TableField));
            }
        }

        public SqlTable[] GetSqlTables()
        {
            if (base.ConnectionString == null)
                return new SqlTable[0];

            SqlConnection connection = new SqlConnection(base.ConnectionString);
            connectionSrting = base.ConnectionString;
            connection.Open();
            using (connection)
            {
                ArrayList list = new ArrayList();
                this.tableNames = GetTableNames(connection);
                if (this.tableNames.Length == 0)
                    return new SqlTable[0];

                foreach (string name in this.tableNames)
                    list.Add(name + " (Non-Query)");
                this.tableNames = (string[])list.ToArray(typeof(string));

                // start a separate thread because we want the GUI to run in a STA
                // Thread thread = new Thread(new ThreadStart(this.RunDialog));
                // thread.ApartmentState = ApartmentState.STA;
                // thread.Start();
                // thread.Join();

                RunDialog();

                list.Clear();
                foreach (string name in this.tableNames)
                {
                    string[] split = name.Split(" ".ToCharArray());
                    switch (split[1].Trim())
                    {
                        case "(Non-Query)":
                            list.Add(new SqlTable(split[0], ExecuteType.NonQuery));
                            break;

                        case "(Scalar)":
                            list.Add(new SqlTable(split[0], ExecuteType.Scalar));
                            break;

                        case "(Reader)":
                            list.Add(new SqlTable(split[0], ExecuteType.Reader));
                            break;

                        case "(XmlReader)":
                            list.Add(new SqlTable(split[0], ExecuteType.XmlReader));
                            break;
                    }
                }

                SqlTable[] SqlTables = (SqlTable[])list.ToArray(typeof(SqlTable));
                foreach (SqlTable table in SqlTables)
                    table.Load(connection);

                return SqlTables;
            }
        }

        public TableField[] GetFields()
        {
            return this.fields;
        }

        #endregion
    }

    public class ReferencedTable : SqlTable
    {
        #region properties

        public string Name { get; set; }

        override public string CommandText
        {
            get
            {
                return string.Empty;
            }
        }

        #endregion

        #region variables
        private string FieldsQueryFormat
        {
            get
            {
                return @"
                        SELECT [o].[name] AS [TableName],
	                  [c].[colorder] AS [Ordinal],
	                  [c].[name] AS [Name],
	                  [t].[name] AS [Type],
	                  [t].[name]+ISNULL(CASE
					                    WHEN [t].[variable] = 1
					                    THEN '('+CAST([c].[length] AS NVARCHAR(10))+')'
					                    ELSE NULL
					                END, '') AS [QualifiedType],
	                  [c].[length] AS [Length],
	                  [c].[isnullable] AS [IsNullable],
	                  (CASE
		                  WHEN [TC].[CONSTRAINT_TYPE] = 'PRIMARY KEY'
		                  THEN 1
		                  ELSE 0
	                   END) AS [IsPrimaryKey],
	                  (CASE
		                  WHEN [TC].[CONSTRAINT_TYPE] = 'FOREIGN KEY'
		                  THEN 1
		                  ELSE 0
	                   END) AS [IsForiegnKey],
	                  (CASE
		                  WHEN [TC].[CONSTRAINT_TYPE] = 'UNIQUE'
		                  THEN 1
		                  ELSE 0
	                   END) AS [IsUnique],
	                  ISNULL([DC].[definition],'') AS [DefaultValue],
	                  OBJECT_NAME([FK].[referenced_object_id]) AS [ReferencedTable],
	                  COL_NAME([FK].[referenced_object_id], [FK].[referenced_column_id]) AS [ReferencedColumn]
                FROM   [dbo].[sysobjects] AS [o]
	                  INNER JOIN [dbo].[syscolumns] AS [c] ON [o].[id] = [c].[id]
	                  INNER JOIN [dbo].[systypes] AS [t] ON [c].[xtype] = [t].[xtype]
									                AND [c].[xusertype] = [t].[xusertype]
	                  LEFT JOIN [INFORMATION_SCHEMA].[KEY_COLUMN_USAGE] AS [CU] ON [c].[name] = [CU].[COLUMN_NAME]
													                   AND [o].[name] = [CU].[TABLE_NAME] 
	                   -- Primary Key, Forign Key & Unique Key
	                  LEFT JOIN [INFORMATION_SCHEMA].[TABLE_CONSTRAINTS] AS [TC] ON [TC].[CONSTRAINT_NAME] = [CU].[CONSTRAINT_NAME] 
	                  -- Forign Key
	                  LEFT JOIN [sys].[foreign_key_columns] AS [FK] ON OBJECT_NAME([FK].[constraint_object_id]) = [CU].[CONSTRAINT_NAME] 
	                  -- Default Constraints
	                  LEFT JOIN [sys].[default_constraints] AS [DC] ON [C].[cdefault] = [DC].object_id
                WHERE  [o].[name] = '{0}'";
            }
        }

        private TableField[] fields;
        #endregion

        #region ctor

        public ReferencedTable(string name, string connectionString)
            : base(connectionString)
        {
            this.Name = name;
        }

        #endregion

        #region public methods
        /// <summary>
        /// Loads fields information
        /// </summary>
        /// <param name="connection"></param>
        public void Load(SqlConnection connection)
        {
            string cmdText = string.Format(this.FieldsQueryFormat, this.Name);

            SqlCommand cmd = new SqlCommand(cmdText, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            using (reader)
            {
                ArrayList list = new ArrayList();
                while (reader.Read())
                    list.Add(new TableField(reader));

                list.Sort(new Comparer());
                this.fields = (TableField[])list.ToArray(typeof(TableField));
            }
        }

        public ReferencedTable GetSqlTable()
        {
            SqlConnection connection = new SqlConnection(base.ConnectionString);
            connection.Open();
            using (connection)
            {
                if (this.Name.Length == 0)
                    return new ReferencedTable(this.Name, base.ConnectionString);

                ReferencedTable sqlTable = new ReferencedTable(this.Name, base.ConnectionString);
                sqlTable.Load(connection);

                return sqlTable;
            }
        }

        public TableField[] GetFields()
        {
            return this.fields;
        }

        #endregion
    }

    public class Comparer : IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            TableField param1 = obj1 as TableField;
            TableField param2 = obj2 as TableField;
            if (param1.Ordinal > param2.Ordinal)
                return 1;
            if (param1.Ordinal < param2.Ordinal)
                return -1;

            return 0;
        }
    }
}