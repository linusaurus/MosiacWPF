using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{ 

public class Product
{
    public Product()
    {
        this.SubAssemblies = new List<SubAssembly>();
    }

    public int ProductID { get; set; }
    public int? ProjectID { get; set; }
    public string ProductName { get; set; }
    public DateTime? ProductionDate { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public decimal? Depth { get; set; }
    public string ArchRef { get; set; }
    public string Note { get; set; }
    public bool? Make { get; set; }
    public int? CPD_id { get; set; }
    public bool? Omit { get; set; }
    public int? SystemFamilyID { get; set; }

    public Project Project { get; set; }
    public List<SubAssembly> SubAssemblies { get; set; }
}

}