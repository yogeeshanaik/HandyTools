using System;

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
    public int ConnectTimeout { get; set; } = 10;

    public override string ToString()
    {
        return Server + "," + Database + "," + User;
    }

    public string ConnectionString
    {
        get
        {
            if (AuthType == AuthTypes.Windows)
                return string.Format("Persist Security Info={0};Integrated Security={1}; database ={2}; server={3}",
                    false,
                    "SSPI",
                    Database,
                    Server
                    );
            else
                return string.Format("Persist Security Info={0};User ID={1};Password={2};Initial Catalog={3};Server={4}",
                    false,
                    User,
                    Password,
                    Database,
                    Server
                    );
        }
    }

    public ServerInfo Clone()
    {
        return new ServerInfo { Server = this.Server, AuthType = this.AuthType, Database = this.Database, User = this.User, Password = this.Password };
    }
}