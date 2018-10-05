using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


public static class Global
{
    public static ServerInfo ServerInfo;
    public static string queryFolderPath = System.IO.Directory.GetCurrentDirectory() + @"\Queries";
    public static string queryFileExtension = "sql";
    public static int resultPanelHeight = 230;
}

