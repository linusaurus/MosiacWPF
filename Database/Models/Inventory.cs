using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{
    public class Inventory
    {
        public int StockTransactionID { get; set; }
        public int? OrderReceiptID { get; set; }
        public int? LineID { get; set; }
        public int? PartID { get; set; }
        public int? StockBillID { get; set; }
        public int? JobID { get; set; }
        public string Location { get; set; }
        public int? ArticleID { get; set; }
        public DateTime? DateStamp { get; set; }
        public decimal? Qnty { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public int? UnitOfMeasure { get; set; }
        public int? TransActionType { get; set; }

        public OrderReciept OrderReciept { get; set; }
        //public StockBill StockBill { get; set; }
    }
}
