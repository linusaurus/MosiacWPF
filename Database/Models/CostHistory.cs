using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;



namespace Database.Models
{
    public class CostHistory
    {
        public int CostChangeID { get; set; }
        public string User { get; set; }
        public int? PartID { get; set; }
        public decimal? UpdatedUnitCost { get; set; }
        public decimal? UpdatedUoPCost { get; set; }
        public string UoP { get; set; }
        public DateTime? DateStamp { get; set; }
    }
}
