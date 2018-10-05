using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    [DataContract]
    public class Navigation : BaseEntity
    {
        [Required]
		[Display(Name="Navigation Id")]
		[DataMember]
		public Int32 NavigationId { get; set; }
		
		[Display(Name="Parent Id")]
		[DataMember]
		public Int32 ParentId { get; set; }
		
		[Display(Name="Display Text")]
		[DataMember]
		public String DisplayText { get; set; }
		
		[Display(Name="Area")]
		[DataMember]
		public String Area { get; set; }
		
		[Display(Name="Controller")]
		[DataMember]
		public String Controller { get; set; }
		
		[Display(Name="Action Method")]
		[DataMember]
		public String ActionMethod { get; set; }
		
		[Display(Name="Display Icon")]
		[DataMember]
		public String DisplayIcon { get; set; }
		
		[Required]
		[Display(Name="Priority")]
		[DataMember]
		public Double Priority { get; set; }
		
		[Required]
		[Display(Name="Is Active")]
		[DataMember]
		public Boolean IsActive { get; set; }
		
		
    }

}