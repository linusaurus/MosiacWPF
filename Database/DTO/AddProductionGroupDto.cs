using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;
using System.ComponentModel;

namespace BadgerData.Services
{
    public class AddProductionGroupDto 
    {
       
        [ReadOnly(true)]
        public int JobID { get; set; }

        [ReadOnly(true)]
        public string JobName { get; set; }

        public string JobDescription { get; set; }

        //public ICollection<ProductionGroup> ProductionGroups { get; set; }

    }
}
