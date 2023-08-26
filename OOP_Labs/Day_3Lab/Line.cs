using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3Lab
{
    internal class Line
    {
        protected int _length;
        protected Point _startPoint;//compistion relation that main part of the line class
        protected Point _endPoint;//compostion
        protected Color _color;//aggreagtion relation it sub part of the line class

        public Line()
        {
            _length = 0;
            _startPoint = new Point();
            _endPoint = new Point();
        }

        public Line(int lenth,Point st_point,Point end_point,Color clr)
        {
            if(_length <= 0)
            {
                _length = 1;
            }
            else
                _length = lenth;

            if (st_point is null)
                _startPoint = new Point();
            else
                _startPoint = st_point;

            if(end_point is null)
                _endPoint = new Point();
            else
                _endPoint = end_point;

            _color = clr;
        }
    }
}
