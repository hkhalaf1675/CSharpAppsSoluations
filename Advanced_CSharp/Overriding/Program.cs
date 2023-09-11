using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber { Real = 5, Imagin = 0 };
            ComplexNumber cInt = 5;
            Console.WriteLine(c1.Equals(5));

            ComplexNumber c2 = new ComplexNumber { Real = 5,Imagin = 5 };
            Console.WriteLine(c1.Equals(c2));

            double n = 5;
            Console.WriteLine(n.Equals(5));

            Console.WriteLine("------------------");

            // the Equals on refernce type
            ComplexNumber cn = new ComplexNumber { Real = 5, Imagin = 5 };
            ComplexNumber cn2 = new ComplexNumber { Real = 5, Imagin = 5 };
            ComplexNumber cn3 = cn;

            Console.WriteLine(cn.Equals(cn3));
        }
    }

    class ComplexNumber
    {
        public int Real { get; set; }
        public int Imagin { get; set; }


        public override string ToString()
        {
            return $"{Real}+{Imagin}i";
        }

        // Equals on object { reference types } work based on refernce not value
        // mean of that if the two object has the sam values but on diff places on heap { return false }
        // and if the two object has the same places on heap { return True }

        // but here we overrride on that and make it compare by value
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber cn)
            {
                return (this.Real == cn.Real) && (this.Imagin == cn.Imagin);
            }
            else
                return false;
        }

        public static implicit operator ComplexNumber(int num)
        {
            return new ComplexNumber() { Real = num, Imagin = 0 };
        }
    }
}
