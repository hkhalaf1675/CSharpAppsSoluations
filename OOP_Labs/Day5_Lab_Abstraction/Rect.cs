using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lab_Abstraction
{
    internal class Rect:Shape
    {
        public Rect(int x, int y):base(x,y)
        {
            
        }

        public override void Draw()
        {
            Console.WriteLine($"X : {x} , Y : {y}");
        }
    }
}
