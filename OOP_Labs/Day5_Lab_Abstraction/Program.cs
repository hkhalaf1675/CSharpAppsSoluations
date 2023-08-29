using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lab_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber num = new ComplexNumber(5, -2);
            Console.WriteLine(num++);
            //Console.WriteLin(num.A + " " + num.B);

            Console.ReadKey();
        }
    }
}
