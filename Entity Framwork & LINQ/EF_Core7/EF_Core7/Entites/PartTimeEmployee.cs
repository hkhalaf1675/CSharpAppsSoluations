using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.Entites
{
    internal class PartTimeEmployee:Employee
    {
        public decimal HourRate { get; set; }
    }
}
