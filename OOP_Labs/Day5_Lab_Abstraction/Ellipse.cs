using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Lab_Abstraction
{
    internal class Ellipse:Circle
    {
        public Ellipse(int x , int y):base(x,y)
        {
            
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
