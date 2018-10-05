using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    [DataContract]
    public class UserLogin : BaseEntity
    {
        [Required]
		[Display(Name="User Login Id")]
		[DataMember]
		public Int64 UserLoginId { get; set; }
		
		[Required]
		[Display(Name="User Login Id")]
		[DataMember]
		public Int64 UserLoginId { get; set; }
		
		[Required]
		[Display(Name="User Id")]
		[DataMember]
		public Int32 UserId { get; set; }
		
		[Required]
		[Display(Name="Login Token")]
		[DataMember]
		public String LoginToken { get; set; }
		
		[Required]
		[Display(Name="Login Date")]
		[DataMember]
		public DateTime LoginDate { get; set; }
		
		[Display(Name="Logout Date")]
		[DataMember]
		public DateTime LogoutDate { get; set; }
		
		[Display(Name="Remarks")]
		[DataMember]
		public String Remarks { get; set; }
		
		
    }

}