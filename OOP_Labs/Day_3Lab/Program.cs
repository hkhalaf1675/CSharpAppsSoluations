using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ShowData();//to show all data of the employee

            Console.WriteLine(emp1.GetBouns());

            Console.WriteLine($"Emp1 Hashcode : {emp1.GetHashCode()}");
            emp1.ShowData();

            Employee emp2 = new Employee();
            Console.WriteLine($"Emp2 : {emp2.GetHashCode()}");
            emp2.DeepCopy(emp1);
            Console.WriteLine($"Emp2 : {emp2.GetHashCode()}");
            emp2.ShowData();

            Console.WriteLine(Employee.Count);
            

            Manager m1 = new Manager();
        }
    }
}
