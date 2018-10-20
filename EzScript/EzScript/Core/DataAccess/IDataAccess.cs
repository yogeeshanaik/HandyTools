using System;
using System.Collections.Generic;
using System.Data;

namespace EzScript.Core
{
    public interface IDataAccess
    {
        string GetServerVersion();

        List<string> GetObjectTypes();

        DataTable GetObjectsList(DateTime fromDate, DateTime toDate, string objectTypes);

        List<string> GetDatabasesList();
    }
}