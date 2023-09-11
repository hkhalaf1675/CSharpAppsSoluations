using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // can not make overlaod on [] : it is only work with indexer
            // can not make overload on = 
            // can not make overload on compund operators { += , -= , *= , /= }
            // they will supported on + , - , * , /

            //int x = 5;
            //int y = -x;
            //Console.WriteLine(y);// will output  -5

            ComplexNumber c1 = new ComplexNumber() { Real = 5, Imagin = 2 };
            ComplexNumber c2 = new ComplexNumber() { Real = 10, Imagin = 3 };

            Console.WriteLine(c1 + c2);

            Console.WriteLine("----------------");

            ComplexNumber c3 = -c1;

            Console.WriteLine(c1);
            Console.WriteLine($"C1 : {c1.GetHashCode()} ");
            Console.WriteLine(c3);
            Console.WriteLine($"C3 : {c3.GetHashCode()} ");

            Console.WriteLine("--------------------");

            ComplexNumber c4 = new ComplexNumber();
            Console.WriteLine($"C4 : {c4.GetHashCode()} ");

            c4 = c2 + 5;
            Console.WriteLine(c4);
            Console.WriteLine($"C4 : {c4.GetHashCode()} ");

            Console.WriteLine("--------------------");

            ComplexNumber c5 = c4 - c3;
            Console.WriteLine(c5);
            Console.WriteLine($"C5 : {c5.GetHashCode()} ");

            Console.WriteLine("--------------------");

            ComplexNumber c6 = new ComplexNumber();
            c6 = 5;
            Console.WriteLine(c6);

            int num = (int)c5;
            Console.WriteLine(num);
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

        #region Operating Overloading on +
        // + between two ComplexNumber
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber() { Real = a.Real + b.Real, Imagin = a.Imagin + b.Imagin };
        }

        // between complexnumber and int on the real part
        public static ComplexNumber operator +(ComplexNumber a, int b)
        {
            return new ComplexNumber() { Real = a.Real + b, Imagin = a.Imagin };
        }

        // same of the prv
        public static ComplexNumber operator +(int a, ComplexNumber b)
        {
            return new ComplexNumber() { Real = b.Real + a, Imagin = b.Imagin };
        }
        #endregion

        #region Overloading ++ or --
        // will overload on ++ operator thought it is postfix or prefix
        // it must to do not use ++ on the code of implementation
        public static ComplexNumber operator ++(ComplexNumber a)
        {
            return new ComplexNumber() { Real = a.Real + 1, Imagin = a.Imagin + 1 };
        }

        public static ComplexNumber operator --(ComplexNumber a)
        {
            return new ComplexNumber() { Real = a.Real - 1, Imagin = a.Imagin - 1 };
        }
        #endregion

        #region Overloading on operator -
        public static ComplexNumber operator -(ComplexNumber a)
        {
            return new ComplexNumber() { Real = -a.Real, Imagin = -a.Imagin };
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber() { Real = a.Real - b.Real, Imagin = a.Imagin - b.Imagin };
        }
        #endregion

        #region overlaoding on *
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber() { Real = a.Real * b.Real, Imagin = a.Imagin * b.Imagin };
        }
        #endregion

        #region Comparison Overlaoding
        // Comparison operator
        // when overload on one it must do the oopsite if it
        // like if we make overload on < it must define the >
        // and so on all comparison operators
        public static bool operator >(ComplexNumber a, ComplexNumber b)
        {
            if (a.Real == b.Real)
                return a.Imagin > b.Imagin;
            return a.Real > b.Real;
        }

        public static bool operator <(ComplexNumber a, ComplexNumber b)
        {
            if (a.Real == b.Real)
                return a.Imagin < b.Imagin;
            return a.Real < b.Real;
        }
        #endregion

        #region Casting Overloading
        public static implicit operator ComplexNumber(int num)
        {
            return new ComplexNumber() { Real = num, Imagin = 0 };
        }

        public static explicit operator int(ComplexNumber num)
        {
            return num.Real;
        } 
        #endregion
    }
}
