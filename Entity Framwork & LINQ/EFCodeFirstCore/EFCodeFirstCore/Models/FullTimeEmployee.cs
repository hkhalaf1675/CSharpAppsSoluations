using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstCore.Models
{
    internal class FullTimeEmployee:Employee
    {
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
    }
}
