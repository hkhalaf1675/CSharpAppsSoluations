using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_OOP_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(12345678912345,"Hassan",5000,"full stack","Giza");
            emp1.DisplayEmpInfo();

            Employee emp2 = new Employee();
            emp2.DisplayEmpInfo();

            emp2.EmpName = "Ahmed";
            emp2.Title = "Front end";

            emp2.DisplayEmpInfo();

            Console.WriteLine("Employees  Count : " + Employee.DisplayCount());

            Console.ReadKey();
        }
    }
}
