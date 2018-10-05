using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    [DataContract]
    public class Permission : BaseEntity
    {
        [Required]
		[Display(Name="Permission Id")]
		[DataMember]
		public Int32 PermissionId { get; set; }
		
		[Required]
		[Display(Name="Permission Name")]
		[DataMember]
		public String PermissionName { get; set; }
		
		[Display(Name="Description")]
		[DataMember]
		public String Description { get; set; }
		
		[Required]
		[Display(Name="Is Default")]
		[DataMember]
		public Boolean IsDefault { get; set; }
		
		[Required]
		[Display(Name="Is Active")]
		[DataMember]
		public Boolean IsActive { get; set; }
		
		[Required]
		[Display(Name="Created By")]
		[DataMember]
		public Int32 CreatedBy { get; set; }
		
		[Required]
		[Display(Name="Created On")]
		[DataMember]
		public DateTime CreatedOn { get; set; }
		
		[Display(Name="Modified By")]
		[DataMember]
		public Int32 ModifiedBy { get; set; }
		
		[Display(Name="Last Modified On")]
		[DataMember]
		public DateTime LastModifiedOn { get; set; }
		
		
    }

}