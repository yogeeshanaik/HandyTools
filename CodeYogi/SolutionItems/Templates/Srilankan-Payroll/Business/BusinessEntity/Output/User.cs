using System;
using System.Runtime.Serialization;

namespace Business.Entities
{
    
    [DataContract]
    public class User : BaseEntity
    {
        public User(){
		IsActive = true;
		IsDeleted = false;
		CreatedOn = DateTime.Now;
		}
        
        [DataMember]
		public Int32 UserId { get; set; }
		
		[DataMember]
		public String UserName { get; set; }
		
		[DataMember]
		public String Password { get; set; }
		
		[DataMember]
		public String FirstName { get; set; }
		
		[DataMember]
		public String LastName { get; set; }
		
		[DataMember]
		public String EmailId { get; set; }
		
		[DataMember]
		public String Mobile { get; set; }
		
		[DataMember]
		public Byte[] ImageBytes { get; set; }
		
		[DataMember]
		public Boolean IsActive { get; set; }
		
		[DataMember]
		public Boolean IsDeleted { get; set; }
		
		[DataMember]
		public Int32 CreatedBy { get; set; }
		
		[DataMember]
		public DateTime CreatedOn { get; set; }
		
		[DataMember]
		public Int32? ModifiedBy { get; set; }
		
		[DataMember]
		public DateTime? LastModifiedOn { get; set; }
		
		
    }

}