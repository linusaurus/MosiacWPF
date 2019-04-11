using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;


namespace Database.DTO
{
    public class InventoryTransactionsDTO
    {
        public int StockTransactionID { get; set; }
        public DateTime DateStamp { get; set; }
        public int? OrderReceiptID { get; set; }
        public int? LineID { get; set; }
        public int? PartID { get; set; }
        public string JobName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal Qnty { get; set; }
        public string TransActionType { get; set; }
    }
}




