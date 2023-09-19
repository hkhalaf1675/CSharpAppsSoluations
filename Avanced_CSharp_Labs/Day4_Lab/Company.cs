using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab
{
    internal class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private Dictionary<Product, int> product_quantity;

        public Company()
        {
            product_quantity=new Dictionary<Product, int>();
        }

        public void AddProductQuantity(Product product,int quantity)
        {
            bool f = true;
            for(int i=0; i<product_quantity?.Count; i++)
            {
                if (product_quantity.ElementAt(i).Key.Equals(product))
                {
                    product_quantity[product_quantity.ElementAt(i).Key] = product_quantity.ElementAt(i).Value + quantity;
                    f = false;
                    break;
                }
            }
            if(f)
                product_quantity.Add(product, quantity);
        }

        public void SellProduct(Product product, int quantity)
        {
            if (product_quantity != null && product_quantity.Count > 0)
            {
                foreach (var item in product_quantity)
                {
                    if (item.Key.Equals(product))
                    {
                        if (item.Value >= quantity)
                        {
                            product_quantity[item.Key] -= quantity;
                            Console.WriteLine($"{quantity} of {item.Key.Name} has been selled");
                        }
                        else
                        {
                            Console.WriteLine("There is no enough Quantity for that Product");
                        }
                        if (item.Value <= 5)
                        {
                            // the code of event here-----------------------------
                            Suppliers sup = new Suppliers();
                            sup.QuantityWarning += Recive_Product;
                        }
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("There is No Products founded");
            }
        }
        // method to send warning of product quantity to supplier
        public void Recive_Product(object s, EventArgs e)
        {
            Console.WriteLine($" is almost finised");
        }
    }
}
