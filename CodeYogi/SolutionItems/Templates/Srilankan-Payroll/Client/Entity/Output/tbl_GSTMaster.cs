using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Client.Entities
{
    
    [DataContract]
    public class tbl_GSTMaster : BaseEntity
    {
        [Required]
		[Display(Name="Gst Master Id")]
		[DataMember]
		public Int32 GstMasterId { get; set; }
		
		[Required]
		[Display(Name="Effective Date")]
		[DataMember]
		public DateTime EffectiveDate { get; set; }
		
		[Required]
		[Display(Name="State Name")]
		[DataMember]
		public String StateName { get; set; }
		
		[Required]
		[Display(Name="Gst Number")]
		[DataMember]
		public String GstNumber { get; set; }
		
		[Display(Name="Pan Number")]
		[DataMember]
		public String PanNumber { get; set; }
		
		[Display(Name="Tan Number")]
		[DataMember]
		public String TanNumber { get; set; }
		
		[Required]
		[Display(Name="C G S T_ Applicable")]
		[DataMember]
		public Boolean CGST_Applicable { get; set; }
		
		[Display(Name="C G S T_ Percentage")]
		[DataMember]
		public Decimal CGST_Percentage { get; set; }
		
		[Required]
		[Display(Name="S G S T_ Applicable")]
		[DataMember]
		public Boolean SGST_Applicable { get; set; }
		
		[Display(Name="S G S T_ Percentage")]
		[DataMember]
		public Decimal SGST_Percentage { get; set; }
		
		[Required]
		[Display(Name="U T G S T_ Applicable")]
		[DataMember]
		public Boolean UTGST_Applicable { get; set; }
		
		[Display(Name="U T G S T_ Percentage")]
		[DataMember]
		public Decimal UTGST_Percentage { get; set; }
		
		[Required]
		[Display(Name="I G S T_ Applicable")]
		[DataMember]
		public Boolean IGST_Applicable { get; set; }
		
		[Display(Name="I G S T_ Percentage")]
		[DataMember]
		public Decimal IGST_Percentage { get; set; }
		
		
    }

}