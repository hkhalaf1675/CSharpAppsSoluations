using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.Entites
{
    internal class FullTimeEmployee:Employee
    {
        public DateOnly HireDate { get; set; }
        public decimal Salary { get; set; }
    }
}
