using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;

namespace Database.Models
{
    public class Employee
    {
        public Employee()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int employeeID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public bool? IsPurchaser { get; set; }
        public string EmployeeEmail { get; set; }
        public bool? Show { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
