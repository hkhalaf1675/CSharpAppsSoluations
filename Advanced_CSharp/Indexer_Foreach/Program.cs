using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I will create class 
            // then I will create another class to make list of the first class
            // I will use the indexer on the second class
            // then I will implement the IEnumberable Interface to make that class able to iterate with foreach

            Student std = new Student(1, "Hassan Tawik", 2.45f);
            Console.WriteLine(std);
            Console.WriteLine("-------------------");

            StudentList stdList = new StudentList(5);
            stdList[1, "Ahmed Tawfik"] = 3.5f;
            stdList[2, "Mohamed Tawfik"] = 3.7f;
            stdList[3, "Hassan Tawfik"] = 2.5f;
            stdList[3, "Hamada Ali"] = 2.7f;
            stdList[3, "Hossam Ali"] = 2.4f;

            foreach (var item in stdList)
                Console.WriteLine(item);

            Console.WriteLine("-------------------");

            stdList.StudentSortGPA();

            foreach (var item in stdList)
                Console.WriteLine(item);

            var ll = stdList.GetEnumerator();
            for(; ll.MoveNext();)
                Console.WriteLine(ll.Current);
        }
    }
}
