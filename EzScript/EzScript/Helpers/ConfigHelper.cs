using System;
using System.Configuration;

namespace EzScript.Core
{
    class ConfigHelper
    {
        // Open App.Config of executable
        static Configuration config =
          ConfigurationManager.OpenExeConfiguration
                     (ConfigurationUserLevel.None);

        public static void AddAppSetting(string key, string value)
        {
            // Add an Application Setting.
            config.AppSettings.Settings.Add(key, value);

            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static bool AddConnectionString(ConnectionStringSettings connectionString)
        {
            if (config.ConnectionStrings.ConnectionStrings[connectionString.Name] != null)
                config.ConnectionStrings.ConnectionStrings[connectionString.Name].ConnectionString = connectionString.ConnectionString;
            else
                // Add an Application Setting.
                config.ConnectionStrings.ConnectionStrings.Add(connectionString);

            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("connectionStrings");
            return true;
        }

        public static ConnectionStringSettingsCollection GetConnectionStrings()
        {
            return ConfigurationManager.ConnectionStrings;
        }

        // Retrieves a connection string by name.
        // Returns null if the name is not found.
        public static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

        // Retrieve a connection string by specifying the providerName.
        // Assumes one connection string per provider in the config file.
        static string GetConnectionStringByProvider(string providerName)
        {
            // Return null on failure.
            string returnValue = null;

            // Get the collection of connection strings.
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            // Walk through the collection and return the first
            // connection string matching the providerName.
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (cs.ProviderName == providerName)
                        returnValue = cs.ConnectionString;
                    break;
                }
            }
            return returnValue;
        }

        static void ToggleConfigEncryption(string exeConfigName)
        {
            // Takes the executable file name without the
            // .config extension.
            try
            {
                // Open the configuration file and retrieve
                // the connectionStrings section.
                Configuration config = ConfigurationManager.
                    OpenExeConfiguration(exeConfigName);

                ConnectionStringsSection section =
                    config.GetSection("connectionStrings")
                    as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section.SectionInformation.UnprotectSection();
                }
                else
                {
                    // Encrypt the section.
                    section.SectionInformation.ProtectSection(
                        "DataProtectionConfigurationProvider");
                }
                // Save the current configuration.
                config.Save();

                Console.WriteLine("Protected={0}",
                    section.SectionInformation.IsProtected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Error");
            }
        }
    }
}