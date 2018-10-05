using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Reflection;

    public enum AuthTypes
    {
        Windows = 1,
        SQLServer = 0
    }

    [Serializable]
    public class ServerInfo
    {
        public AuthTypes AuthType { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }

        public override string ToString()
        {
            return Server + "," + Database + "," + User;
        }

        public ServerInfo Clone()
        {
            return new ServerInfo { Server = this.Server, AuthType = this.AuthType, Database = this.Database, User = this.User, Password = this.Password };
        }
    }

    [Serializable]
    public class Settings
    {
        public List<ServerInfo> Servers = new List<ServerInfo>();

        public int ConnectionTimeout { get; set; }

        private static Settings settings = null;

        public static string SettingsFile
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\EzScript.cfg"; }
        }

        internal static string Title
        {
            get { return ((Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]) as AssemblyTitleAttribute).Title; }
        }

        public static Settings Instance
        {
            get
            {
                if (settings == null)
                {
                    settings = new Settings();
                    if (File.Exists(SettingsFile))
                    {
                        var serializer = new XmlSerializer(typeof(Settings));
                        using (var reader = File.OpenText(SettingsFile))
                        {
                            settings = (Settings)serializer.Deserialize(reader);
                        }
                    }
                }
                return settings;
            }
        }

        public void Save()
        {
            if (File.Exists(SettingsFile))
                File.Delete(SettingsFile);
            var serializer = new XmlSerializer(typeof(Settings));
            using (var writer = File.OpenWrite(SettingsFile))
            {
                serializer.Serialize(writer, this);
            }
        }

        public ServerInfo FindServer(string Server)
        {
            return Servers.FirstOrDefault((s) => s.Server.ToLower() == Server.ToLower());
        }
    }
