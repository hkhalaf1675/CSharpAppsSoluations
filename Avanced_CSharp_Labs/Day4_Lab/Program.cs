using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.SellProduct(new Product() { ID = 1, Name = "Product1" }, 5);
            company.AddProductQuantity(new Product() { ID = 1, Name = "Product1" }, 5);
            company.AddProductQuantity(new Product() { ID = 2, Name = "Product2" }, 5);
            company.AddProductQuantity(new Product() { ID = 2, Name = "Product2" }, 4);
            company.SellProduct(new Product() { ID = 1, Name = "Product1" }, 4);

            Console.WriteLine("------------");
        }
    }
}
