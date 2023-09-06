using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Trainee : IPayable,IComparer
    {
        int salary;

        //implement the IPayable Property
        public int Salary {
            get { return salary; }
            set 
            {
                if (value > 3000)
                    throw new TraineeSalaryException("Salary must be less than or equal 3000");
                else
                    salary = value;
            }
        }

        //implement the Method of IPayable Interface
        public int ShowPayment()
        {
            return salary;
        }


        // IComparer Interface implementation
        public int Compare(object x, object y)
        {
            Trainee t1 = (Trainee)x;
            Trainee t2 = (Trainee)y;
            if (t1.salary > t2.salary)
                return 1;
            else if (t1.salary < t2.salary)
                return -1;
            else
                return 0;
        }
    }
}
