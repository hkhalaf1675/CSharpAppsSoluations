using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static method can only call it the class it self and can not call it by the objects

            // non static method can call it by the objects but can not call it by the class

            Test.StaticMethod();

            //Test.NonStaticMethod();// can see it

            Test t =new Test();
            t.NonStaticMethod();

        }

        
    }

    class Test
    {
        static int staticCounter;
        int nonStaticCounter;
        public static void StaticMethod()
        {
            Console.WriteLine("Print From Static Methods");

            staticCounter = 0;
            //nonStaticCounter = 0; // will give error

            //static methods can only make operation on the static variables
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("Print From Non Static Method");

            staticCounter = 1;
            nonStaticCounter = 2;

            // Non static methods can make operation son the static and non static variables
        }
    }
}
