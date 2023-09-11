using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_SealedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sealed class : is class can not inherit from it
            // but it can inherit from another class
            // and can create from it objects

            Test1 t = new Test1() { Y = 1 , X = 1};

            // Sealed Method
            // can not define method do not override as sealed 
            // so the first declare of any method can not define it as a sealed method
            // sealed method it prevent any class will inherit from it class from overidding on it
        }
    }

    #region Sealed Class
    sealed class Test1 : Test2// can inheritt from another class
    {
        public int X { get; set; }
    }

    class Test2 //:Test1// but can not inherit from Sealed class
    {
        public int Y { get; set; }
    } 
    #endregion

    #region Sealed Method
    abstract class TypeA
    {
        public int X { get; set; }

        public /*sealed*/ virtual void PrintX()// can not make that method sealed
        {
            Console.WriteLine($"X:{X}");
        }
    }

    class TypeB : TypeA
    {
        public sealed override void PrintX() // so any class will inherit from that class can not override on that method
        {
            base.PrintX();
        }
    }

    class TypeC : TypeB
    {
        public  /*override*/ void PrintX()// will give an error can not override from sealed method
        {
            // what is happen here
            // it like to hide the parent method { can use new or not }
            base.PrintX();
        }
    } 
    #endregion
}
