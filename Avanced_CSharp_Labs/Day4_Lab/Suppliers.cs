using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab
{
    internal class Suppliers
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public event EventHandler QuantityWarning;

        public void SupplyProduct(Product product, EventArgs e)
        {
            Console.WriteLine("From Suppliers");
            this.QuantityWarning(product,e);
        }
    }
}
