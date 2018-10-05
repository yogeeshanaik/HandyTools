using Microsoft.Data.ConnectionUI;
using System;
using System.Configuration;
using System.Data.SqlClient;
namespace DatabaseCatalogReader
{
    public abstract class DatabaseCatalog
    {
        #region variables

        private string connectionString = "";
        private string name = "Database";

        #endregion variables

        #region properties

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

        public string DatabaseName
        {
            get
            {
                return this.name;
            }
        }

        public abstract string CommandText { get; }

        #endregion properties

        #region ctor

        public DatabaseCatalog()
        {
            ConnectionString = DialogGetConnectionString();
        }

        public DatabaseCatalog(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        #endregion ctor

        #region private methods

        private string DialogGetConnectionString()
        {
            try
            {
                ConnectionString = ReadConnectionString("DatabaseCatalogReader.SqlConnectionString");
            }
            catch
            {
            }

            if (IsServerConnected(ConnectionString))
                return ConnectionString;

            DataSource sqlDataSource = new DataSource("MicrosoftSqlServer", "Microsoft SQL Server");
            sqlDataSource.Providers.Add(DataProvider.SqlDataProvider);
            DataConnectionDialog dcd = new DataConnectionDialog();
            dcd.DataSources.Add(sqlDataSource);
            dcd.SelectedDataProvider = DataProvider.SqlDataProvider;
            dcd.SelectedDataSource = sqlDataSource;
            if (DataConnectionDialog.Show(dcd) == System.Windows.Forms.DialogResult.OK)
            {
                ConnectionString = dcd.ConnectionString;
                SaveConnectionString("DatabaseCatalogReader.SqlConnectionString", ConnectionString);
            }

            return ConnectionString;
        }

        #endregion private methods

        #region public-methods

        public bool IsConnected()
        {
            return (this.connectionString.Length > 0);
        }

        #endregion public methods

        private bool IsServerConnected(string conString)
        {
            try
            {
                using (var l_oConnection = new SqlConnection(conString))
                {
                    try
                    {
                        l_oConnection.Open();
                        return true;
                    }
                    catch //(SqlException)
                    {
                        return false;
                    }
                }
            }
            catch //(SqlException exp)
            {
                return false;
            }
        }

        private void SaveConnectionString(string name, string value)
        {
            // Open App.Config of executable
            System.Configuration.Configuration config =
             ConfigurationManager.OpenExeConfiguration
                        (ConfigurationUserLevel.None);

            // Add an Application Setting.
            config.AppSettings.Settings.Add(name, value);

            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }

        private string ReadConnectionString(string name)
        {
           return  ConfigurationManager.AppSettings[name].ToString();
        }

    }
}