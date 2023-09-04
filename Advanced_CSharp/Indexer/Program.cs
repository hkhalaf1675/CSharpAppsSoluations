using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // it is like property but can sent to it more than one input parameter
            // it is shape on c sharp to use [] 
            // it is proerty inizialize on the scope of class
            // it is property without name
            // using name of class or struct with []
            // make the object like an array or dictionary
            // can sent an input parameter on it or more than one

            PhoneBook pb = new PhoneBook(5);

            pb[0, "Hassan"] = 0123456789;
            pb[1, "ahmed"] = 0987654321;

            Console.WriteLine(pb["asd"]);
            Console.WriteLine(pb[4]);

            for(int i=0; i<pb.Size; i++)
                Console.WriteLine(pb[i]);

        }
    }
}
