namespace Database.Models
{
    public class Attachment
    {
        public int AttachmentID { get; set; }
        public string AttachmentDescription { get; set; }
        public int? OrderNum { get; set; }
        public string Ext { get; set; }
        public string src { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
