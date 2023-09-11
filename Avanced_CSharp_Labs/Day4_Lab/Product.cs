using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Product p)
            {
                return p.ID == ID;
            }
            else
                return false;
        }
    }
}
