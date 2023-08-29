using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab_Polymorphism
{
    internal class Circle:Shape
    {
        public Circle(int x, int y ):base(x,y)
        {
            
        }
        protected double r;//raduis

        public virtual double Area()
        {
            return 3.14 * r * r;
        }

        //Overload Area method
        public double Area(double r2)
        {
            return 3.14 * r2 * r2;
        }

        public sealed override void Display()
        {
            Console.WriteLine($"Raduis : {r} , and the Area : {this.Area()}");
        }
    }
}
