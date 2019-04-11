using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{
    public class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
            this.Parts = new HashSet<Part>();
        }

        public int UID { get; set; }
        public string UOM { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}
