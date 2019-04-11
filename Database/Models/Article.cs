using System;


namespace Database.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string ArticleName { get; set; }
        public DateTime? ProductionDate { get; set; }
        public int? ProjectID { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Depth { get; set; }
        public string ArchRef { get; set; }
        public string Note { get; set; }

        public Project Project { get; set; }
    }
}
