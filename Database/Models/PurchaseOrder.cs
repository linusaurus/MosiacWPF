using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{
    public class PurchaseOrder
    {
        public PurchaseOrder()
        {
            this.Attachments = new HashSet<Attachment>();
            //this.Notifications = new HashSet<Notification>();
            this.PurchaseLineItems = new HashSet<PurchaseLineItem>();
        }

        public int OrderNum { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? Expected_Date { get; set; }
        public int? SupplierID { get; set; }
        public int? EmployeeID { get; set; }
        public string SalesRep { get; set; }
        public int? Job_id { get; set; }
        public bool? SuppressTax { get; set; }
        public int? ShipID { get; set; }
        public decimal? OrderTotal { get; set; }
        public bool? Recieved { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? Tax { get; set; }
        public bool? IsBackOrder { get; set; }
        public DateTime? RecievedDate { get; set; }
        public decimal? SubTotal { get; set; }
        public string Memo { get; set; }
        public int? OrderState { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string OrderFormat { get; set; }

        public Supplier Supplier { get; set; }
        public Employee Employee { get; set; }
        public Job Job { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
        //public ICollection<Notification> Notifications { get; set; }
        public ICollection<PurchaseLineItem> PurchaseLineItems { get; set; }
    }
}
