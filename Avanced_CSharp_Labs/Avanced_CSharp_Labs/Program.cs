using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Avanced_CSharp_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstQ List Of Students and Exception Handling
            List<Student> students = new List<Student>()
            {
                new Student(1,"ahmed "),
                new Student(2,"mohamed"),
                new Student(),
                new Student()
                {
                    ID = 3,
                    Name="Abdo"
                },
                new Student()
                {
                    ID = 4,
                    Name = "Hossam"
                }
            };

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("----- After Sorting ----");

            students.Sort();

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            try
            {
                students.Add(new Student(5,"hamada"));
            }
            catch(IndexOutOfRangeException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            #endregion

            Console.WriteLine("------------------------");

            #region SecondQ Generic List Class
            GList<int> numbers = new GList<int>(5);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            Console.WriteLine("Last Item : {0}",numbers.LastItem());
            numbers.Remove();
            int removedNum = numbers.Remove();

            Console.WriteLine("After Remove ,Last Item : {0}", numbers.LastItem());
            #endregion

            Console.WriteLine("------------------------");

            #region Question3 Employee Trainee IPayable and Question5 Trainee Salary Exception
            Employee emp = new Employee();
            emp.Salary = 4000;
            Console.WriteLine(emp.ShowPayment());

            Trainee trn = new Trainee();
            trn.Salary = 2500;
            Console.WriteLine(trn.ShowPayment());
            #endregion

            Console.WriteLine("-----------------------");

            #region Question4 TwoItemOperator
            TwoItemOperation<int> test = new TwoItemOperation<int>();

            Console.WriteLine(test.Sum(5, 5));

            Console.WriteLine(test.Sub(10, 8));

            Console.WriteLine(test.Div(5, 5));
            #endregion

            Console.WriteLine("-----------------------------");

        }
    }
}
