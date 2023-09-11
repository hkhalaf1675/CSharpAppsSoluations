using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Day2_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1 Sorting Array Of Students
            Student[] students = new Student[5]
                {
                    new Student(1,"Ahmed Tawfik"),
                    new Student(2,"Mohamed Tawfik"),
                    new Student(5,"Hassan Tawfik"),
                    new Student(4,"Hossam Ali"),
                    new Student(3,"Hamada Ali"),
                };

            foreach(var item in students)
                Console.WriteLine(item);

            Console.WriteLine("----->>> After Sorting <<<-----");

            Array.Sort(students);
            foreach(var item in students)
                Console.WriteLine(item);

            #endregion

            Console.WriteLine("------------------------");

            #region Question2 Indexer PostGradute List
            PostGraduateList gradList = new PostGraduateList(5);

            gradList[0] = new PostGraduate(1, "Hassan Khalaf");
            gradList[1] = new PostGraduate(2, "Ahmed Tawfik");
            gradList[2] = new PostGraduate(3, "Mohamed Tawfik");

            //Console.WriteLine(gradList[0]);

            var e = gradList.GetEnumerator();
            while(e.MoveNext())
                Console.WriteLine(e.Current);

            #endregion


            
        }
    }
}
