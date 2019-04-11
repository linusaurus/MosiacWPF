namespace Database.Models
{
    public class Asset
    {
        public int AssetID { get; set; }
        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public int? ManuID { get; set; }
        public string AssetClass { get; set; }
        public decimal? Price { get; set; }
        public string Location { get; set; }
        public int? SupplierID { get; set; }
        public string ManuPartNum { get; set; }
        public string Tag { get; set; }
    }
}



