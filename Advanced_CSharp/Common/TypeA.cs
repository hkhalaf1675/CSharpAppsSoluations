using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // Project Class Library
    // is contain from classes , interfaces,struct,Enum without Main Method


    //default access modifers on namespace is internal
    // the available access modifers is Internal or Public
    public struct TypeA
    {
        #region sum definations
        // on struct
        // can contain on it variables or functions or property or event{point to function}

        // the main deiffernce between the struct and the class is :
        //----the struct is value type
        //----the class is refernce type
        //---- the struct do not support all principles of oop
        //------- do not support inhertance

        // to use that type on another project : 
        //--------- on the References right click on it and select add Refenence
        //--------- select on the project then select the name of project that the type on it and add it

        //default access modifer is Private
        //int _x;//Private can see it only the same class or scope

        //internal int _y;//can see it on the same project

        //public int z;//public can see it on any place on the same soluation
        #endregion

        // Imagin Number
        // The Imagin Number is Consist from real part and imagin part
        // like the sqrt of -25 is equal 5i
        // and the square of 3i is equal -9

        // so it consists from two part
        int _real;
        int _imagin;

        public int Real
        {
            get { return _real; }
            set { _real = value; }
        }

        public int Imagin
        {
            get { return _imagin; }
            set 
            {
                if(value > 0)
                    _imagin = value;
                else
                    _imagin = 0;
            }
        }

        public TypeA(int real,int imagin)
        {
            _real = real;
            if(real > 0)
                _imagin = imagin;
            else
                _imagin = 0;
        }
        // when define ctor on struct must call variables on it
        // can not give attribute and forget the other

        //can define more than one ctor
        public TypeA(int x)
        {
            _real = _imagin = x;
        }

        // can not define default ctor 

        public override string ToString()
        {
            return string.Concat($"{_real}",(_imagin>0)?$"-{_imagin}i":"");
        }
    }
}
