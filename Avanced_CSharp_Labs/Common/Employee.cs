using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Employee : IPayable
    {
        int salary;

        //implement the IPayable Property
        public int Salary
        {
            get { return salary; }
            set { salary = value >= 2000 ? value : 2000; }
        }

        //implement the Method
        public int ShowPayment()
        {
            return salary;
        }
    }
}
