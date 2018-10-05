using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    // [DataContract]
    public class ClientGst : BaseEntity
    {
        public ClientGst(){
		CreatedOn = DateTime.Now;
		}
         
        [Required]
		[Display(Name="Client Gst Id")]
		public Int32 ClientGstId { get; set; }
		
		[Required]
		[Display(Name="Company Id")]
		public Int32 CompanyId { get; set; }
		
		[Required]
		[Display(Name="State Name")]
		public String StateName { get; set; }
		
		[Display(Name="Gst Number")]
		public String GstNumber { get; set; }
		
		[Display(Name="Pan Number")]
		public String PanNumber { get; set; }
		
		[Display(Name="Tan Number")]
		public String TanNumber { get; set; }
		
		[Required]
		[Display(Name="Invoicing State Name")]
		public String InvoicingStateName { get; set; }
		
		[Required]
		[Display(Name="Created By")]
		public Int32 CreatedBy { get; set; }
		
		[Required]
		[Display(Name="Created On")]
		public DateTime CreatedOn { get; set; }
		
		
    }

}