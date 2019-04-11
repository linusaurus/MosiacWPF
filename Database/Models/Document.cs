using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;


namespace Database.Models
{
    public class Document
    {
        public Document()
        {
            this.DocumentParts = new HashSet<DocumentParts>();
        }

        public int DocID { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentView { get; set; }
        public int? PartID { get; set; }

        public ICollection<DocumentParts> DocumentParts { get; set; }
    }
}
