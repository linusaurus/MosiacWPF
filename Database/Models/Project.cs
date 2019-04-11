using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{
    public class Project
    {
        public Project()
        {
            this.Articles = new HashSet<Article>();
        }

        public int ProjectID { get; set; }
        public int? ParentID { get; set; }
        public string ProjectName { get; set; }
        public int? JobLinkID { get; set; }
        public DateTime? Created { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsContracted { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
