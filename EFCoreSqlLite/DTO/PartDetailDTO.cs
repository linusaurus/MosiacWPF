using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;

namespace Database.DTO
{
    public class PartDetailDTO
    {
        // Core Properties
        public int PartID { get; set; }
        public string PartName { get; set; }
        public string PartNum { get; set; }
        public string ItemDescription { get; set; }
        // Remove this later
        public int? SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public bool? UseSupplierNameFlag { get; set; }
        // Manu ---------------------------------------------
        public int? ManuID {get;set;}
        public string ManufacturerPartNum { get; set; }
        public string ManufacturerName { get; set; }
        // Physical Properies -------------------------------
        public int? UID { get; set; }
        public int? PartType { get; set; }
        public decimal Cost { get; set; }
        public string Location { get; set; }
        public int? FinishID { get; set; }
        public string SKU { get; set; }
        public decimal UnitToPurchaseFactor { get; set; }
        public bool CarbTrack { get; set; }
        public bool ObsoleteFlag { get; set; }
        // Dimensional ---------------------------------------
        public decimal Weight { get; set; }
        public decimal Waste { get; set; }
        public decimal MarkUp { get; set; }
        // Auditing ------------------------------------------
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
