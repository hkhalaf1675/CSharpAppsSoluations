using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            //can access Id because it is public
            emp.Id = 1;
            Console.WriteLine(emp.Id);

            // can not access name directly : can access it by calling methods
            emp.SetName("Hassan");
            Console.WriteLine(emp.GetName());

            // can not access salary directlyn but can access it by property 
            emp.Salary = 2500;
            Console.WriteLine(emp.Salary);

            Console.WriteLine(emp.ToString());
        }
    }
}
