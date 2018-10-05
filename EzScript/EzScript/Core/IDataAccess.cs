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

namespace EzScript.Core
{
    interface IDataAccess
    {
        List<string> GetObjectTypes();

        List<string> GetObjectsList(DateTime fromDate, DateTime toDate, string objectTypes);

        List<string> GetDatabasesList(ServerInfo objServerInfo);
    }
}
