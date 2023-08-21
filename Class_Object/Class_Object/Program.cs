using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test bouns function
            Employee emp = new Employee(1, "Hassan", 25, 4, 4000);
            emp.display();
            Console.WriteLine("Bouns " + emp.Emp_Bouns());
            Console.WriteLine("------------------");

            // create array of Employee of length 6
            Employee[] employees = new Employee[6];

            //add data on employee num1
            employees[0] = new Employee(2, "Ahmed", 22, 5, 5000);
            employees[0].display();

            // make Emp2 copy of Emp1
            employees[1] = new Employee(employees[0]);

            Console.WriteLine("Employee num 1");
            employees[0].display();

            Console.WriteLine("Employee num 2");
            employees[1].display();

            //add data on employee num4
            employees[4] = new Employee(3, "Mhmd", 30, 7, 6000);
            employees[4].display();

            Console.WriteLine("---------------");

            //employee num3 reference
            employees[3] = employees[4];

            employees[3].display();
            employees[4].display();

            Console.WriteLine("---------------");

            employees[3].Employee_Name = "ABDO";
            employees[3].display();
            employees[4].display();
            
            //Employee empShallow = employees[4];
            //empShallow.display();

            Console.ReadKey();
        }
    }
}
