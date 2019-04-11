using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{
    public class Supplier
    {
        public Supplier()
        {
            this.Parts = new HashSet<Part>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Zip { get; set; }
        public bool? Active { get; set; }
        public int? Category { get; set; }
        public int? AccountType { get; set; }
        public string AccountNumber { get; set; }

        public ICollection<Part> Parts { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
