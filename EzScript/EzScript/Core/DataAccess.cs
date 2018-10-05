/****************** Request to the Developers *****************

You are free to use, modify and distribute any portion of this code. 
The only requirement to do that, you need to keep the developer name, as provided below to recognize and encourage original work:
Thank you..
 
=======================================================
   
Architecture Designed and Implemented By:
Yogeesha Naik
Twitter: http://facebook.com/yogeesha.thangode | Mail: yogishdj@live.com
   
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace EzScript.Core
{
    class DataAccess : IDataAccess
    {
        #region properties
        private string fromDate;
        private string toDate;

        public string FromDate
        {
            set
            {
                if (value.Length == null)
                {
                    throw new Exception("From date is required!");
                }
                fromDate = value;
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
                if (value.Length == null)
                {
                    throw new Exception("To date is required!");
                }
                toDate = value;
            }
            get
            {
                return toDate;
            }
        }
        #endregion

        ServerInfo objServerInfo = null;
        public DataAccess(ServerInfo _objServerInfo)
        {
            objServerInfo = _objServerInfo;
        }

        /// <summary>
        /// get list of database object types from sys.objetcs
        /// </summary>
        /// <returns></returns>
        public List<string> GetObjectTypes()
        {
            List<string> listObjectTypes = new List<string>();
            string sqlQuery = "select distinct type_desc from sys.objects(nolock)  where type in ('P','U','TR','FN','TF','TR')";
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
        public List<string> GetObjectsList(DateTime from_ModifiedDate, DateTime to_ModifiedDate, string objectTypes)
        {
            List<string> listObjectsList = new List<string>();
            string sqlQuery = "select '<#'+type_desc+'#>dbo.'+name COLLATE Latin1_General_CI_AI as name from sys.objects(nolock) where modify_date between '"
                + from_ModifiedDate + "' and '" + to_ModifiedDate
                + "' and type_desc in (" + (objectTypes == string.Empty ? "''" : objectTypes) + ") order by type_desc";
            var data = SQLHelper.Query(sqlQuery, objServerInfo);
            data.AsEnumerable().OrderBy(r => r.Field<string>("name")).ForEach((d) => listObjectsList.Add(d["name"].ToString()));
            return listObjectsList;
        }

        public List<string> GetDatabasesList(ServerInfo objServerInfo)
        {
            List<string> listDatabasesList = new List<string>();
            var databases = SQLHelper.Query("SELECT name FROM sys.databases(nolock)", objServerInfo);
            databases.AsEnumerable().OrderBy(r => r.Field<string>("name")).ForEach((d) =>listDatabasesList.Add(d["name"].ToString()));
            return listDatabasesList;
        }
    }
}
