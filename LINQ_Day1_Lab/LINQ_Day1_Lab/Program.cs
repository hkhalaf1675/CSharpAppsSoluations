using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Day1_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1 Sleect Book Title,ISBN
            var Q1 = SampleData.Books.Select(B => new { B.Title, B.Isbn });

            foreach (var item in Q1)
            {
                Console.WriteLine($"{item.Title} => {item.Isbn}");
            }
            #endregion

            Console.WriteLine("-----------------------------------");

            #region Question2 Select First 3
            var Q2 = SampleData.Books.Where(B => B.Price > 25).Take(3);

            foreach (var item in Q2)
                Console.WriteLine(item);
            #endregion

            Console.WriteLine("-----------------------------------");

            #region Question3 Book Tiyle With Publisher Name
            var Q3 = SampleData.Books.Select(B => new
            {
                B.Title,
                Publisher = SampleData.Publishers.Where(P => B.Publisher == P).Select(P => P.Name)
            });

            foreach (var item in Q3)
                Console.WriteLine($"{item.Title} => {item.Publisher}");

            Console.WriteLine("-----------------------------------");

            var Q3_2 = from B in SampleData.Books
                       join P in SampleData.Publishers
                       on B.Publisher equals P
                       select new { B.Title, P.Name };
            foreach (var item in Q3_2)
                Console.WriteLine($"{item.Title} => {item.Name}");
            #endregion

            Console.WriteLine("-----------------------------------");

            #region Question4 Count Of Books price more than 20
            int Q4 = SampleData.Books.Count(B => B.Price > 20);

            Console.WriteLine($"Number Of Books : {Q4}");
            #endregion

            Console.WriteLine("-----------------------------------");

            #region Q5 Select Book Title,Price,Subject
            var Q5 = SampleData.Books.Select(B => new { B.Title, B.Price, B.Subject })
                        .OrderBy(B => B.Title).OrderByDescending(B => B.Price);

            foreach (var item in Q5)
                Console.WriteLine($"{item.Title} => {item.Price} => {item.Subject.Name}");
            #endregion

            Console.WriteLine("-----------------------------------");

            #region Question6 Subject with it's related books
            var Q6 = from S in SampleData.Subjects
                     from B in SampleData.Books
                     where S == B.Subject
                     select new
                     {
                         S.Name,
                         B.Title
                     };
            foreach (var item in Q6)
                Console.WriteLine($"{item.Name} => {item.Title}");

            var Q6_2 = from S in SampleData.Subjects
                       select new
                       {
                           S.Name,
                           Books = SampleData.Books.Where(B => B.Subject == S)
                       };

            Console.WriteLine("-----------------------------------");

            foreach (var item in Q6_2)
            {
                Console.WriteLine(item.Name);
                foreach (var item2 in item.Books)
                    Console.WriteLine(item2.Title);
                Console.WriteLine("---");
            }
            #endregion

            Console.WriteLine("-----------------------------------");

            #region Question7 
            var Q7 = SampleData.GetBooks().OfType<Book>().Select(B => B.Title);

            foreach (var item in Q7)
                Console.WriteLine(item); 
            #endregion

            Console.WriteLine("-------------------------+++++++");

            var Q8 = SampleData.Books.GroupBy(
                P => P.Publisher,
                P => P.Subject,
                (key, g) => new { Publishers = key, Subjects = g.ToList() }
                );

            foreach(var item in Q8)
            {
                Console.WriteLine(item.Publishers);
                foreach(var item2 in item.Subjects)
                    Console.WriteLine("---"+item2.Name);
            }

        }
    }
}
