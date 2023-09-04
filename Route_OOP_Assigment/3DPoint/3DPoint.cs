using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    internal class _3DPoint
    {
        #region Attributes
        int _cordinateX;
        int _cordinateY;
        int _cordinateZ;
        #endregion

        #region Properties
        public int CordinateX
        {
            get { return _cordinateX; }
            set { _cordinateX = value; }
        }
        public int CordinateY
        {
            get { return _cordinateY; }
            set { _cordinateY = value; }
        }
        public int CordinateZ
        {
            get { return _cordinateZ; }
            set { _cordinateZ = value; }
        }
        #endregion

        #region Constructors
        public _3DPoint(int x,int y,int z)
        {
            _cordinateX=x>0?x:0;
            _cordinateY=y>0?y:0;
            _cordinateZ=z>0?z:0;
        }

        //chaining
        public _3DPoint(int x,int y):this(x,y,0)
        {}
        #endregion

    }
}
