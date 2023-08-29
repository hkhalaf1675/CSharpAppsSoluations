using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lab_Abstraction
{
    internal abstract class Shape
    {
        public int x;
        public int y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void Draw();
    }
}
