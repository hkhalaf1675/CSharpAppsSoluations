using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINQ.ListGenerators;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Test LINQ Methods
            #region Explanation
            // LINQ : language independent Query
            // use 40+ C# extension functions (Query Operators) Against Data { On Enumerable class }
            //L2Object {LINQ 2 Object}
            //L2XML { LINQ to XML }
            //L2ADO { LINQ to ADO } : ADO is the oldest tecnology of dot net to interact with data
            //L2SQL (ORM) object Relational Mapping
            //L2EF { LINQ to Entity Framework } ( ORM ) 

            // Extension Method is that the method will be member function of bject and the ojbject can use it
            // all the LINQ functions is extention methods

            // Anonymous Type
            // is a class genereated by compiler becaues the name of it is not important to the developer

            // any objcet implement the IEnumberable Interface called Sequance or collection
            // there is local sequances : 
            // that is L2Object , L2ADO , L2XML

            // or remote sequances :
            // that is L2SQL , L2EF

            // thers are three type of linq operators : 
            // 1- take input sequence -->> and output another sequance
            // 2- take input sequance -->> output single element
            // 3- take no input(with out any input) -->> output sequance 
            #endregion

            //List<string> technologyCompanies = new List<string>
            //{
            //    "Microsoft",
            //    "Apple",
            //    "Amazon",
            //    "Google",
            //    "Facebook",
            //    "Samsung",
            //    "IBM",
            //    "Intel",
            //    "Oracle",
            //    "Adobe"
            //};

            //// Numbers Large 
            //List<int> numbers = new List<int>
            //{
            //    987654321,
            //    123456789,
            //    876543210,
            //    456789123,
            //    789123456,
            //    321654987,
            //    // Add more numbers here...
            //};

            ////  Samll Numbers 
            //List<int> smNumbers = new List<int> { 2, 4, 6, 8, 5, 7, 9, 13, 14, 20, 25, 18 };


            //var numMod2 = Enumerable.Where(smNumbers, i => i % 2 == 0);
            //foreach (int i in numMod2)
            //    Console.Write($"{i} , ");
            //Console.WriteLine();

            //// it is the same when we write 
            //var numMod2_2 = smNumbers.Where(i => i % 2 == 0);

            //foreach (int i in numMod2)
            //    Console.Write($"{i} , ");
            //Console.WriteLine();

            ////Fluent Syntax { way to use LINQ function on c# }
            //var numMod3Desc = smNumbers.Where(i => i % 3 == 0).OrderByDescending(i => i);
            //foreach (int i in numMod3Desc)
            //    Console.Write($"{i} , ");
            //Console.WriteLine();

            //// Query expression or Query Syntax { like sql } - { way to use LINQ function on c# }
            //// Not Valid with all LINQ operators
            //var numMod3Asc = from item in smNumbers
            //                 where item % 3 == 0
            //                 orderby item
            //                 select item;

            //foreach (int i in numMod3Asc)
            //    Console.Write($"{i} , ");
            //Console.WriteLine();
            #endregion


            #region LINQ Data Testing
            // test to check that can get data from file
            //Console.WriteLine(ProductList[0]);


            #region Where Close

            //var result = ProductList.Where(i => i.UnitPrice > 50);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            // another way give the same results
            //result = from p in ProductList
            //         where p.UnitPrice > 50
            //         select p;
            //foreach (var item in result)
            //    Console.WriteLine(item);

            // all products that the unit stock of it more than 100
            //result = from p in ProductList
            //         where p.UnitsInStock > 100
            //         select p;
            //foreach (var item in result)
            //    Console.WriteLine(item);

            // search about the index of item
            //result = ProductList.Where((p, i) => p.UnitsInStock > 100 && i < 10);
            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion


            #endregion

            
        }

    }
}
