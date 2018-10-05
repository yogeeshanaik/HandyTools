using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    [DataContract]
    public class Trace : BaseEntity
    {
        [Required]
		[Display(Name="Trace Id")]
		[DataMember]
		public Int64 TraceId { get; set; }
		
		[Required]
		[Display(Name="Trace Date Time")]
		[DataMember]
		public DateTime TraceDateTime { get; set; }
		
		[Display(Name="Trace Category")]
		[DataMember]
		public String TraceCategory { get; set; }
		
		[Display(Name="Trace Description")]
		[DataMember]
		public String TraceDescription { get; set; }
		
		[Display(Name="Stack Trace")]
		[DataMember]
		public String StackTrace { get; set; }
		
		[Display(Name="Detailed Error Description")]
		[DataMember]
		public String DetailedErrorDescription { get; set; }
		
		[Display(Name="User Id")]
		[DataMember]
		public Int32 UserId { get; set; }
		
		
    }

}