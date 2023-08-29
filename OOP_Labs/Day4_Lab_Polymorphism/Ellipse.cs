using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab_Polymorphism
{
    internal class Ellipse:Circle
    {
        public Ellipse(int x , int y):base(x,y)
        {
            
        }
        public new void Display()
        {
            Console.WriteLine($"X : {x} , Y : {y}");
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }
    }
}
