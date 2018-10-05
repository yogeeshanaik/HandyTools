
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    // [DataContract]
    public class User : BaseEntity
    {
        public User(){
		IsActive = true;
		IsDeleted = false;
		CreatedOn = DateTime.Now;
		}
         
        [Required]
		[Display(Name="User Id")]
		public Int32 UserId { get; set; }
		
		[Required]
		[Display(Name="User Name")]
		public String UserName { get; set; }
		
		[Required]
		[Display(Name="Password")]
		public String Password { get; set; }
		
		[Required]
		[Display(Name="First Name")]
		public String FirstName { get; set; }
		
		[Display(Name="Last Name")]
		public String LastName { get; set; }
		
		[Required]
		[Display(Name="Email Id")]
		public String EmailId { get; set; }
		
		[Display(Name="Mobile")]
		public String Mobile { get; set; }
		
		[Display(Name="Image Bytes")]
		public Byte[] ImageBytes { get; set; }
		
		[Required]
		[Display(Name="Is Active")]
		public Boolean IsActive { get; set; }
		
		[Required]
		[Display(Name="Is Deleted")]
		public Boolean IsDeleted { get; set; }
		
		[Required]
		[Display(Name="Created By")]
		public Int32 CreatedBy { get; set; }
		
		[Required]
		[Display(Name="Created On")]
		public DateTime CreatedOn { get; set; }
		
		[Display(Name="Modified By")]
		public Int32 ModifiedBy { get; set; }
		
		[Display(Name="Last Modified On")]
		public DateTime LastModifiedOn { get; set; }
		
		
    }

}