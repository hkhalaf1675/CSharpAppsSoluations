using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab_Polymorphism
{
    internal class Shape
    {
        protected int x;
        protected int y;

        public Shape(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Display()
        {
            Console.WriteLine($"X : {x} , Y : {y}");
        }
    }
}
