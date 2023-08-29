using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA typeA;// that is allocate 8 byte on stack memeory {4byte fro _real , 4byte for _imagin}
            typeA = new TypeA();

            TypeA a = new TypeA(10,-2);
            // the use of new does not mean that allocate on heap memeory
            // and here we use new Keyword to spacify the ctor

            Console.WriteLine(a);

            a.Real = 5;
            a.Imagin = -2;
            Console.WriteLine(a);

            a.Imagin = 2;
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
