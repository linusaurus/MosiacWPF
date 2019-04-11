using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Models
{ 
    public class Claim
    {
        public int ClaimID { get; set; }
        public int? SupplierID { get; set; }
        public int? OrderNum { get; set; }
        public string SupplierOrder { get; set; }
        public System.DateTime ClaimDate { get; set; }
        public int? EmployeeID { get; set; }

        public ICollection<ClaimItem> ClaimItems { get; set; }
    }
}
