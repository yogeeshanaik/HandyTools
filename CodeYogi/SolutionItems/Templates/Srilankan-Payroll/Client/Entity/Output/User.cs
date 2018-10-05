using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    [DataContract]
    public class User : BaseEntity
    {
        [Required]
		[Display(Name="User Id")]
		[DataMember]
		public Int32 UserId { get; set; }
		
		[Required]
		[Display(Name="User Name")]
		[DataMember]
		public String UserName { get; set; }
		
		[Required]
		[Display(Name="Password")]
		[DataMember]
		public String Password { get; set; }
		
		[Required]
		[Display(Name="First Name")]
		[DataMember]
		public String FirstName { get; set; }
		
		[Display(Name="Last Name")]
		[DataMember]
		public String LastName { get; set; }
		
		[Required]
		[Display(Name="Email Id")]
		[DataMember]
		public String EmailId { get; set; }
		
		[Display(Name="Mobile")]
		[DataMember]
		public String Mobile { get; set; }
		
		[Display(Name="Image Bytes")]
		[DataMember]
		public Byte[] ImageBytes { get; set; }
		
		[Required]
		[Display(Name="Is Active")]
		[DataMember]
		public Boolean IsActive { get; set; }
		
		[Required]
		[Display(Name="Is Deleted")]
		[DataMember]
		public Boolean IsDeleted { get; set; }
		
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