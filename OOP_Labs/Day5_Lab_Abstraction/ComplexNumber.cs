using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lab_Abstraction
{
    internal class ComplexNumber
    {
        #region Fields
        int a;
        int b;
        #endregion

        #region Constructors
        public ComplexNumber(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public ComplexNumber(int a):this(a,-3)
        {}

        #endregion

        #region Properties
        public int A
        {
            get { return a; }
            set
            {
                if(value > 0)
                {
                    a = value;
                }
                else
                {
                    a = 0;
                }
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                b = value;
            }
        }
        #endregion

        #region Methods
        public double GetMagnitude()
        {
            return Math.Sqrt(a*a + b*b);
        }

        //Operating OverLoading
        public static bool operator >=(ComplexNumber num1 , ComplexNumber num2)
        {
            return (num1.a >= num2.a && num1.b >= num2.b);
        }

        public static bool operator <=(ComplexNumber num1, ComplexNumber num2)
        {
            return (num1.a <= num2.a && num1.b <= num2.b);
        }

        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.a + num2.a, num1.b + num2.b);
        }

        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.a - num2.a, num1.b - num2.b);
        }

        public static ComplexNumber operator ++(ComplexNumber num)
        {
            return new ComplexNumber(num.a + 1, num.b + 1);
        }

        //implicit
        public static implicit operator ComplexNumber(int num)
        {
            return new ComplexNumber(num);
        }
        //explicit
        public static explicit operator int(ComplexNumber num)
        {
            return num.a;
        }

        //equal
        public override bool Equals(object obj)
        {

            return base.Equals((ComplexNumber)obj);
        }

        //to string
        public override string ToString()
        {
            return $"A : {a} , B : {b}";
        }

        #endregion
    }
}
