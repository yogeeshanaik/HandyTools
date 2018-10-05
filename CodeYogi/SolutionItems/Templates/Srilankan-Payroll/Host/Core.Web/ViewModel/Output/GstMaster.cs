
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    // [DataContract]
    public class GstMaster : BaseEntity
    {
        public GstMaster(){
		CGST_Applicable = false;
		SGST_Applicable = false;
		UTGST_Applicable = false;
		IGST_Applicable = false;
		CreatedOn = DateTime.Now;
		}
         
        [Required]
		[Display(Name="Gst Master Id")]
		public Int32 GstMasterId { get; set; }
		
		[Required]
		[Display(Name="Effective Date")]
		public DateTime EffectiveDate { get; set; }
		
		[Required]
		[Display(Name="State Id")]
		public Int32 StateId { get; set; }
		
		[Required]
		[Display(Name="State Name")]
		public String State_Name { get; set; }
		
		[Display(Name="Gst Number")]
		public String GstNumber { get; set; }
		
		[Display(Name="Pan Number")]
		public String PanNumber { get; set; }
		
		[Display(Name="Tan Number")]
		public String TanNumber { get; set; }
		
		[Required]
		[Display(Name="CGST Applicable")]
		public Boolean CGST_Applicable { get; set; }
		
		[Display(Name="CGST Percentage")]
		public Decimal CGST_Percentage { get; set; }
		
		[Required]
		[Display(Name="SGST Applicable")]
		public Boolean SGST_Applicable { get; set; }
		
		[Display(Name="SGST Percentage")]
		public Decimal SGST_Percentage { get; set; }
		
		[Required]
		[Display(Name="UTGST Applicable")]
		public Boolean UTGST_Applicable { get; set; }
		
		[Display(Name="UTGST Percentage")]
		public Decimal UTGST_Percentage { get; set; }
		
		[Required]
		[Display(Name="IGST Applicable")]
		public Boolean IGST_Applicable { get; set; }
		
		[Display(Name="IGST Percentage")]
		public Decimal IGST_Percentage { get; set; }
		
		[Display(Name="Created By")]
		public Int32 CreatedBy { get; set; }
		
		[Required]
		[Display(Name="User Name")]
		public String UserName { get; set; }
		
		[Required]
		[Display(Name="Created On")]
		public DateTime CreatedOn { get; set; }
		
		
    }

}