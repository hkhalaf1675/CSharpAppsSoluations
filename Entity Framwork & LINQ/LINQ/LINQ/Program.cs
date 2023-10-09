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


            #region Where : Filteration

            //var result = ProductList.Where(i => i.UnitsInStock > 50);
            ////foreach (var item in result)
            ////    Console.WriteLine(item);

            ////another way give the same results
            //result = from p in ProductList
            //         where p.UnitPrice > 50
            //         select p;
            ////foreach (var item in result)
            ////    Console.WriteLine(item);

            //// all products that the unit stock of it more than 100
            //result = from p in ProductList
            //         where p.UnitsInStock > 100
            //         select p;
            ////foreach (var item in result)
            ////    Console.WriteLine(item);

            //// search about the index of item { indexer }
            //// that type of where close only vaild of fluent use
            //// can not use it with the other shape of where { shape like sql }
            //result = ProductList.Where((p, i) => p.UnitsInStock > 100 && i < 10);
            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region Select : Transformation

            //var result = ProductList.Select(p => (p.ProductID,p.ProductName)) ;
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// another way to use select
            //result = from p in ProductList
            //         select (p.ProductID,p.ProductName);
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// where and select { condidtion { filteration }  and selection {transformation } }
            //var anonymousType = from P in ProductList
            //                    where P.UnitsInStock < 10
            //                    select new { ID = P.ProductID, P.ProductName };
            ////foreach (var item in anonymousType)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// it can make  new list of products with any conditions new you need 
            //var ProductListSale = from P in ProductList
            //                      where P.UnitsInStock < 10 && P.UnitsInStock > 0
            //                      select new Product() 
            //                      { 
            //                          ProductID = P.ProductID,
            //                          ProductName = P.ProductName,
            //                          Category = P.Category,
            //                          UnitPrice = 0.5M * P.UnitPrice,
            //                          UnitsInStock = P.UnitsInStock 
            //                      };
            ////foreach(var item in  ProductListSale)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Console.WriteLine($"Product Sale : {ProductListSale.Count()}");

            //var anonymousType2 = ProductList.Where(P => P.UnitsInStock < 10 && P.UnitsInStock > 0)
            //                            .Select((P, i) => new { Index = i, P.ProductName });
            //foreach (var item in anonymousType2)
            //{
            //    Console.WriteLine(item);
            //}

            //// can use select before where in fluent shape
            //// but can not use it in sql shape

            //var results = ProductList.Select(p => (p.ProductName, p.UnitPrice * 1.5M))
            //                            .Where(P => P.Item2 > 20);
            #endregion

            #region Orderby : Ordering Elements

            //// order by asec
            //var result = ProductList.OrderBy(P => P.UnitPrice);
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// the sql way
            //result = from P in ProductList
            //         orderby P.UnitPrice
            //         select P;
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// order by desc
            //result = ProductList.OrderByDescending(P => P.UnitPrice);
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// the sql shape

            //result = from P in ProductList
            //         orderby P.UnitPrice descending
            //         select P;

            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// ordering by more than one attribute

            //result = ProductList.OrderBy(P => P.UnitPrice)
            //                    .ThenBy(P => P.UnitsInStock)
            //                    .ThenBy(P => P.ProductName);
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// the sql shape 
            //result = from P in ProductList
            //         orderby P.UnitPrice descending, P.UnitsInStock ascending, P.ProductName
            //         select P;
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// where and order by and select
            //var resultss = ProductList.Where((P, i) => P.UnitsInStock < 10 && i < 20)
            //                    .OrderBy(P => P.UnitPrice)
            //                    .ThenByDescending(P => P.UnitsInStock)
            //                    .Select(P => (P.ProductName, P.UnitPrice, P.UnitsInStock));

            ////foreach (var item in resultss)
            ////{
            ////    Console.WriteLine(item);
            ////}

            #endregion

            /*
            //// do not throw any exception if the sequance is empty;
            //// if the sequence is null will throw a compiler error
            //List<int> list = new List<int>();
            //var res = list.OrderBy(i => i);
            //foreach (var i in res)
            //{
            //    Console.WriteLine(i);
            //}*/

            #region Imidiate Exuction { Output Single Element } {First , Last ,Single,ElementAt }

            //// First or Last : it is perfer use the other ones of them
            //// FirstOrDefault , LastOrDefault
            //// can not use sql shape on those

            //var SingleProduct = ProductList.First();

            //SingleProduct = ProductList.Last();

            //// return depending on condition

            //SingleProduct = ProductList.First(P => P.UnitsInStock == 0); // 

            //SingleProduct = ProductList.Last(P => P.UnitsInStock == 0);

            //Console.WriteLine(SingleProduct);

            //// if the sequence is empty will throw an exception
            //// to handle that there is : 
            //List<int> list = new List<int>();
            ////var res = list.First();// will throw invalidoperation

            //var res = list.FirstOrDefault();// if the seqance is empty will take the default value of it's datatype

            //res = list.LastOrDefault(i => i > 0);

            //Console.WriteLine(res);

            //// Hybrid Syntax : it is (Query Expression Sql).Fluent

            //SingleProduct = (from P in ProductList
            //                 where P.UnitsInStock == 0
            //                 select P).LastOrDefault();

            //SingleProduct = ProductList.ElementAt(5);
            ////the best case of it :
            //SingleProduct = ProductList.ElementAtOrDefault(5);

            //Console.WriteLine(SingleProduct);

            #endregion

            #region Aggregate - Imidiate Exuction { return values } {Max , Min , Avg , Sum}

            //decimal maxPrice = ProductList.Max(P => P.UnitPrice);
            //Console.WriteLine(maxPrice);

            //Product maxProduct = ProductList.Max(); // but must be there is a Icomparabale Interface on product
            //Console.WriteLine(maxProduct);

            //decimal minPrice = ProductList.Min(P => P.UnitPrice);
            //Console.WriteLine(minPrice);

            //Product minProduct = ProductList.Min();
            //Console.WriteLine(minProduct);

            //decimal sumPrices = ProductList.Sum(P => P.UnitPrice);
            //Console.WriteLine(sumPrices);

            //decimal avgPrice = ProductList.Average(P => P.UnitPrice);
            //Console.WriteLine(avgPrice);

            //long productsCount = ProductList.LongCount();
            //Console.WriteLine(productsCount);

            //int productCountBasedonCondition = ProductList.Count(P => P.UnitsInStock == 0);
            //Console.WriteLine(productCountBasedonCondition);

            #endregion

            #region Generator operators :  take no input and output sequance { Range , Repeat , Empty } 

            ///// three static methods
            ///// can only call them by Enumerable class

            //// create an empty seqance from any datatype
            //var EmptySeq = Enumerable.Empty<Product>();
            //Console.WriteLine(EmptySeq);
            //foreach (var item in EmptySeq)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------");

            //// create seqance of repeated item of any datatype
            //var repeatedSeq = Enumerable.Repeat(ProductList[3], 3);
            //Console.WriteLine(repeatedSeq);
            //foreach(var item in repeatedSeq)
            //    Console.WriteLine(item.GetHashCode());// the same refernce

            //Console.WriteLine("---------------------");

            //var repeatedSeqInt = Enumerable.Repeat(3, 5);
            //Console.WriteLine(repeatedSeqInt);
            //foreach(var item in repeatedSeqInt)
            //    Console.WriteLine(item.GetHashCode());

            //Console.WriteLine("---------------------");

            //var rangeSeq = Enumerable.Range(0, 3);
            //Console.WriteLine(rangeSeq);
            //foreach( var item in rangeSeq)
            //    Console.WriteLine(item);
            #endregion

            #region Select Many

            // take sequance as an input and output a new sequance
            // output sequance count > input sequance count

            // do not throw any exception if the input sequance is empty

            //List<string> namesList = new List<string>()
            //{
            //    "Hassan Tawfik",
            //    "Ahmed tawfik",
            //    "Mohamed Tawfik",
            //    "Abdo"
            //};


            //var res = namesList.SelectMany(FN => FN.Split(' '));
            //foreach(string name in res)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("-------------------------------");

            //// the query expression (sql way )
            //res = from FN in namesList
            //      from SN in FN.Split(' ')
            //      select SN;

            //foreach (string name in res)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("--------------------");

            //// we can use any linq method with it

            //res = namesList.SelectMany(FN => FN.Split(' '))
            //                .OrderByDescending(N => N);

            //foreach (string name in res)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region set Operators { Concat , Union , Distinct , ,Intersect , Except }

            //var seq1 = Enumerable.Range(0, 100);// output : 0,99
            //var seq2 = Enumerable.Range(50, 100);// output : 50,149

            //// concat the two sequances ( join two sequances togther )
            //var result = seq1.Concat(seq2);

            //// join the two sequances without duplicated 
            //result = seq1.Union(seq2);

            //// remove duplicated from sequance
            //result = result.Distinct();

            //// get the elements that in left sequance and do not in the right sequance
            //result = seq1.Except(seq2);

            //// get the elements that intersect 
            //result = seq1.Intersect(seq2);


            //foreach ( var item in result )
            //{
            //    Console.Write($"{item} , ");
            //}
            //Console.WriteLine();
            #endregion

            #region Quantifiers : return bool value { Any , All }

            var seq1 = Enumerable.Range(0, 100);// output : 0,99
            var seq2 = Enumerable.Range(50, 100);// output : 50,149

            // check if the sequance is empty(false) or not(True)
            var res = seq1.Any();

            res = seq1.Any(Num => Num > 550);// return false
            res = seq1.Any(Num => Num > 50);// return true

            // check if all the element of sequance is more than or equal the zer0
            res = seq1.All(Num => Num >= 0);//return true
            res = seq1.All(Num => Num >= 5);// return false

            Console.WriteLine(res);
            #endregion

            #endregion


        }

    }
}
