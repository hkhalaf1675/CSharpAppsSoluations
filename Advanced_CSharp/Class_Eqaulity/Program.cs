using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Class_Eqaulity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Equals Method on Value type : work based on value
            int x = 5, y = 5, z = 7;
            Console.WriteLine(x.Equals(y));// return True
            Console.WriteLine(x.Equals(z));// return False

            Console.WriteLine("--------------------");

            // but on reference type : it works based on refernce{the place on heap}
            // if the same place return True
            // else till the values are the same return False

            Test t1 = new Test() { X = 5, Y = 5 };
            Test t2 = new Test() { X = 5, Y = 5 };
            Test t3 = t1;
            Test t4 = default;

            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1.Equals(t3));
            Console.WriteLine(t1.Equals(t4));
            Console.WriteLine("-------------------");
            Console.WriteLine(t4?.Equals(t1)??false);

            Console.WriteLine("------------------------------");

            // testb using referenceEquals with value type
            int xx = 5;
            Console.WriteLine(Object.ReferenceEquals(xx,xx));// will output False : why
            // firstly the ReferenceEquals(object o1,object o2) : take two parameters of type object
            // the object is reference type and it is the parent of all types
            // so when we sent int datatype to it
            // will converting the x to object {boxing}
            // that it will take int { stack memeory }  and go to object { heap memeory }
            // so the first object allocate place on heap 
            // and the second object alloacte another place on heap
            // so the reference of those objects on heapp not equals s
            // so will output the False

            



        }
    }

    class Test
    {
        public int X { get; set; }
        public int Y { get; set; }

        // the first way of equality is Override on Equals Methods
        public override bool Equals(object obj)
        {
            //if(obj is Test t)
            //    return (this.X ==  t.X) && (this.Y == t.Y);
            //return false;

            // Another way
            Test right = obj as Test;
            if (right == null)
                return false;

            // nut the ways above does not handle one case by be give anot good result
            // if there is aclass inherit from that class 
            // it will cast to the parent
            // but it should not be equals that class
            // because it is datatye and that class is another datatype
            // to handle that case
            if (this.GetType() != right.GetType()) 
                return false;

            else
                return (X==right.X) && (Y==right.Y);


            
        }

        // second way is : Equals (object o1,object o2)
        // that is overloading 
        // that method is based on the Equals(object obj) method
        // if the above method works depend on value : that method will work depened on value
        // if the above method works depend on reference : that method will work on reference
        public static bool Equals(Test t1,Test t2)
        {
            return t1.Equals(t2);
        }

        // the third way is ReferenceEquals(object o1,object o2) and it works depend on reference
        public static bool ReferenceEquals(Test t1 , Test t2)
        {
            return true;
        }

        // the last way is to use == operator
        // and that perfer to don't overload on it
        // to make the user have the two options
        // if he want to compare depending Value use Equals
        // and if want to compare depending Refernce use ==
        //public static bool operator ==(Test t1,Test t2)
        //{
        //    return t1.Equals(t2);
        //}
        //public static bool operator !=(Test t1, Test t2)
        //{
        //    return !t1.Equals(t2);
        //}
    }

    struct Test2
    {
        // Equality Operators
        // Equals works value equality

        // Equals(object o1,object o2) : because it depend on the above so it wroks value equality

        // RefernceEquals(object o, object o2) : not suitable on struct

        // == operator : not default impemented 
        // so if we need to use it must implement it fisrt

        // the equals default on the struct is so slow
        // so you should implement override on it 

        int X { get; set; }
        int Y { get; set; }

        public override bool Equals(object obj)
        {
            if(obj is  Test2 t2)
                return (X==t2.X) && (Y==t2.Y);
            else
                return false;
        }
    }
}
