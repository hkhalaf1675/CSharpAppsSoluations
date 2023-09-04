using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefType_PassBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //when pass array by value and use use new with the array on method : 
            // it does not affect on the hashcode(reference on memeory) on the main array {on main function}

            // but when using ref { pass array by reference } 
            // the hashcode of the main array change to the hashcode the sub array(method array)

            // gethashcode do not work with primtive data type
            int x = 5;
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine("--------------------");

            int[] arr = new int[5] {5,5,5,5,5};
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine(arr.GetHashCode());
            Console.WriteLine("-------------------");
            TestMethod( arr);
            Console.WriteLine("-----------------");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            Console.WriteLine("----------------------");
            Console.WriteLine(arr.GetHashCode());

        }

        static void TestMethod( int[] arr)
        {
            arr = new int[5];
            Console.WriteLine(arr.GetHashCode());
            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                arr[i] = i;
            }
        }
    }
}
