using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class PartTypes
    {
        [Key]
        public int PartTypeID { get; set; }
        public string PartTypeName {get;set;} 
        public int Categoryid { get; set; }
    }
}
