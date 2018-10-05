using System;
using System.Runtime.Serialization;

namespace AssociatePayroll.Web.Controllers
{
    
    [DataContract]
    public class DDLEvents : BaseEntity
    {
        public DDLEvents(){
		EventDate = DateTime.Now;
		}
        
        [DataMember]
		public DateTime EventDate { get; set; }
		
		[DataMember]
		public String EventType { get; set; }
		
		[DataMember]
		public String EventDDL { get; set; }
		
		[DataMember]
		public String EventXML { get; set; }
		
		[DataMember]
		public String DatabaseName { get; set; }
		
		[DataMember]
		public String SchemaName { get; set; }
		
		[DataMember]
		public String ObjectName { get; set; }
		
		[DataMember]
		public String HostName { get; set; }
		
		[DataMember]
		public String IPAddress { get; set; }
		
		[DataMember]
		public String ProgramName { get; set; }
		
		[DataMember]
		public String LoginName { get; set; }
		
		
    }

}