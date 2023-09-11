using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Lab
{
    internal class Program
    {
        public static void Sum(int num1 , int num2)
        {
            Console.WriteLine($"Sum : {num1+num2}");
        }
        public static void Sub(int num1, int num2)
        {
            Console.WriteLine($"Sub : {num1 - num2}");
        }
        public static void Mul(int num1, int num2)
        {
            Console.WriteLine($"Mul : {num1 * num2}");
        }
        public static void Divid(int num1, int num2)
        {
            Console.WriteLine($"Mul : {num1 / num2}");
        }
        // function to check if the salary under 10000
        public static bool CheckSalary(Employee emp)
        {
            return emp.Salary < 10000;
        }

        // function to check if the expression above 5 year
        public static bool CheckExperience(Employee emp)
        {
            return emp.Experience > 5;
        }

        // function to check if the employee should promote
        public static bool PromotionCriteria(Employee emp)
        {
            if(CheckExperience(emp))
                return true;
            if(CheckSalary(emp))
                return true;
            return false;
        }

        // function to return list of employees that should promote
        public static List<Employee> Promote(Employee[] emps, Predicate<Employee> delg)
        {
            List<Employee> PromotedEmps = new List<Employee>();
            foreach (Employee emp in emps)
            {
                if(delg(emp))
                    PromotedEmps.Add(emp);
            }
            return PromotedEmps;
        }
        
        // function to display employees salary above 8000
        public static void DisplayEmpAbove(Employee emp,Predicate<Employee> de)
        {
            if(de(emp))
                Console.WriteLine(emp);
        }

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];
            employees[0] = new Employee(1,"Ahmed",11000,"Male",4);
            employees[1] = new Employee(2,"Mohamed",11000,"Male",6);
            employees[2] = new Employee(3, "Hossam", 9000,"Male",4);
            employees[3] = new Employee(4, "Hamada", 8000,"Male",6);
            employees[4] = new Employee(5, "Ismail", 120000,"Male",3);

            var promoted = Promote(employees, CheckExperience);

            foreach (Employee emp in promoted)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("-----------------------------");


            foreach (Employee emp in employees)
                DisplayEmpAbove(emp, (Employee i) => i.Salary > 8000);

            Console.WriteLine("------------------------");


            // Mutlti
            Action<int,int> delMuti = Sum;
            delMuti += Sub;
            delMuti += Mul;
            delMuti += Divid;

            delMuti(5, 5);
        }
    }
}
