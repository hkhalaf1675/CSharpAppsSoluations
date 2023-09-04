using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the most benfit of inhertance is : code generalization
            // it like an abstract class and all members inside it abstract { but is not class }
            // it is prototype for functions and properties that will be implemented on the class 
            // can not define attributes on interface
            // when declare interface the best practaice of to start with Char I 
            // can implement from more than one interface 
            // struct can implement from interfaces because it is not class or inhertance
            // any object implement from interface should implement all methods on it
            // the interface it should minmale as could as

            // the array has function called Sort
            // it used to sort array elements
            // it use the built in interface IComparable


            #region Fib Test Array
            //int[] FibArr = new int[10];
            //FibArr[0] = 1;
            //FibArr[1] = 1;
            //for(int i=2; i<FibArr?.Length; i++)
            //{
            //    FibArr[i] = FibArr[i - 1] + FibArr[i - 2];
            //}
            //for(int i=0; i<FibArr?.Length; i++)
            //{
            //    Console.Write(FibArr[i] + " , ");
            //}
            //Console.WriteLine();
            #endregion

            Console.WriteLine("------------------------");

            ISeries fib;
            fib = new FibSeries();

            ProcessSeries(fib);

            Console.WriteLine("-----------------------------");
            Employee[] empArr = new Employee[5]
                {
                    new Employee(1,"Ahmed Tawfik" , 10000M),
                    new Employee(2,"Ahmed Tawfik" , 11000M),
                    new Employee(3,"Ahmed Tawfik" , 12000M),
                    new Employee(4,"Ahmed Tawfik" , 15000M),
                    new Employee(5,"Ahmed Tawfik" , 1000M)
                };

            foreach (Employee emp in empArr)
                Console.WriteLine(emp.ToString());

            Array.Sort(empArr);

            Console.WriteLine("------------------------------");

            foreach (var item in empArr)
            {
                Console.WriteLine(item.ToString());
            }


        }

        static void ProcessSeries(ISeries series)
        {
            for(int i=0; i<10; i++)
            {
                Console.Write(series.Current + " , ");
                series.GetNext();
            }
            Console.WriteLine();
            series.Reset();
        }

    }
}
