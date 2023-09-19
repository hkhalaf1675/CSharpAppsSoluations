using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGidViewForm_1
{
    internal class Employee
    {

        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime Birthday { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name : {Name} , Address : {Address} , Salary : {Salary}";
        }
    }
}
