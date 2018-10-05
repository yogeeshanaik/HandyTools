using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    [DataContract]
    public class RolePermission : BaseEntity
    {
        [Required]
		[Display(Name="Role Id")]
		[DataMember]
		public Int32 RoleId { get; set; }
		
		[Required]
		[Display(Name="Permission Id")]
		[DataMember]
		public Int32 PermissionId { get; set; }
		
		
    }

}