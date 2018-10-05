using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    [DataContract]
    public class UserRole : BaseEntity
    {
        [Required]
		[Display(Name="User Role Id")]
		[DataMember]
		public Int32 UserRoleId { get; set; }
		
		[Required]
		[Display(Name="User Id")]
		[DataMember]
		public Int32 UserId { get; set; }
		
		[Required]
		[Display(Name="Role Id")]
		[DataMember]
		public Int32 RoleId { get; set; }
		
		
    }

}