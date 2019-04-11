using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;


namespace Database.Models
{
    public class DocumentParts
    {
        public int PartID { get; set; }
        public int DocID { get; set; }

        public Part Part { get; set; }
        public Document Document { get; set; }
    }
}
