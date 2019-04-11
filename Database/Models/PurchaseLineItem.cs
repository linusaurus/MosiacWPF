using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{
    public class PurchaseLineItem
    {
        public int LineID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int? JobID { get; set; }
        public int? VendorID { get; set; }
        public int? PartID { get; set; }
        public decimal? UnitCost { get; set; }
        public string Description { get; set; }
        public decimal? Qnty { get; set; }
        public decimal? Extended { get; set; }
        public bool? Recieved { get; set; }
        public int? OrderReceiptID { get; set; }
        public int? Uom { get; set; }
        public string UoP { get; set; }
        public int? ArticleID { get; set; }
        public int? BomID { get; set; }
        public decimal? AmountReceived { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Thick { get; set; }
        public decimal? Weight { get; set; }
        public string SupplierPartName { get; set; }
        public decimal? UoPPrice { get; set; }
        public string BCode { get; set; }
        public string Note { get; set; }
        public bool? Rejected { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
