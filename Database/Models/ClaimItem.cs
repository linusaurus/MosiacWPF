using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;


namespace Database.Models
{
    public class ClaimItem
    {
        public ClaimItem()
        {
            this.ClaimDocuments = new HashSet<ClaimDocument>();
        }

        public int ClaimItemID { get; set; }
        public int? ClaimID { get; set; }
        public int? LineID { get; set; }
        public int? partID { get; set; }
        public string Bcode { get; set; }
        public string Description { get; set; }
        public int? TransActionType { get; set; }
        public int? ProductID { get; set; }
        public string DefectDescription { get; set; }

        public Claim Claim { get; set; }

        public ICollection<ClaimDocument> ClaimDocuments { get; set; }
    }
}
