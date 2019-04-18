using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class Part
    {
        public Part()
        {
            this.DocumentParts = new HashSet<DocumentParts>();
            
        }

        public int PartID { get; set; }
        public string ItemName { get; set; }
        [Required(ErrorMessage ="A description for the part is required")]
        [StringLength(240)]
        public string ItemDescription { get; set; }
        public string PartNum { get; set; }
        public int? ManuID { get; set; }

        public bool? ObsoluteFlag { get; set; }
        public int? PartTypeID { get; set; }
        public decimal? Cost { get; set; }
        public string UOP { get; set; }
        public decimal? UOPCost { get; set; }
        public int? UID { get; set; }
        public string Location { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Waste { get; set; }
        public decimal? MarkUp { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierDescription { get; set; }
        public int? FinishID { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? UseSupplierNameFlag { get; set; }
        public decimal? UnitToPurchaseFactor { get; set; }
        public string ManuPartNum { get; set; }
        public string SKU { get; set; }
        public bool? CARBtrack { get; set; }
        // depricated -----------
        public string CARBlevel { get; set; }

        public PartTypes PartTypes { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public Supplier Supplier { get; set; }
        
        public ICollection<DocumentParts> DocumentParts { get; set; }
        public ICollection<UnitOfPurchase> UnitOfPurchases { get; set; }
    }
}
