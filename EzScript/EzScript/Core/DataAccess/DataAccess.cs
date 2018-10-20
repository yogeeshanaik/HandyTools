using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EzScript.Core
{
    class DataAccess : IDataAccess
    {
        #region properties

        string fromDate;
        string toDate;

        public string FromDate
        {
            set
            {
                fromDate = value ?? throw new Exception("From date is required!");
            }
            get
            {
                return fromDate;
            }
        }

        public string ToDate
        {
            set
            {
                toDate = value ?? throw new Exception("To date is required!");
            }
            get
            {
                return toDate;
            }
        }

        #endregion properties

        ServerInfo objServerInfo = null;

        public DataAccess(ServerInfo _objServerInfo)
        {
            objServerInfo = _objServerInfo;
        }

        public string GetServerVersion()
        {
            return (string)SQLHelper.ExecuteScalar("SELECT @@version", objServerInfo);
        }

            /// <summary>
            /// get list of database object types from sys.objetcs
            /// </summary>
            /// <returns></returns>
            public List<string> GetObjectTypes()
        {
            List<string> listObjectTypes = new List<string>();
            string sqlQuery = "select distinct type_desc from sys.objects(nolock) where type in ('P','U','TR','FN','TF') ";
            var data = SQLHelper.Query(sqlQuery, objServerInfo);
            data.AsEnumerable().OrderBy(r => r.Field<string>("type_desc")).ForEach((d) => listObjectTypes.Add(d["type_desc"].ToString()));
            return listObjectTypes;
        }

        /// <summary>
        /// get objects list
        /// </summary>
        /// <param name="from_ModifiedDate"></param>
        /// <param name="to_ModifiedDate"></param>
        /// <param name="objectTypes"></param>
        /// <returns></returns>
        public DataTable GetObjectsList(DateTime from_ModifiedDate, DateTime to_ModifiedDate, string objectTypes)
        {
            var sqlQuery = @"SELECT type_desc AS [Type],
                               s.name AS [Schema],
                               o.name AS [Name],
                               o.modify_date AS [Modifiy Date],
                               o.create_date AS [Create Date]
                        FROM sys.objects o
                             INNER JOIN sys.schemas s ON s.[schema_id] = o.[schema_id]
                        WHERE modify_date BETWEEN '" + from_ModifiedDate + "' and '" + to_ModifiedDate + @"'
                              AND type_desc IN(" + (objectTypes == string.Empty ? "''" : objectTypes) + @")
                        ORDER BY o.modify_date DESC;";
            return SQLHelper.Query(sqlQuery, objServerInfo);
        }

        public List<string> GetDatabasesList()
        {
            List<string> listDatabasesList = new List<string>();
            var databases = SQLHelper.Query("SELECT name FROM sys.databases(nolock)", objServerInfo);
            databases.AsEnumerable().OrderBy(r => r.Field<string>("name")).ForEach((d) => listDatabasesList.Add(d["name"].ToString()));
            return listDatabasesList;
        }
    }
}