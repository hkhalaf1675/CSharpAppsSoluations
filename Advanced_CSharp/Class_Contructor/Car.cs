using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Contructor
{
    internal class Car
    {
        int id = 1;
        // the compiler will take id = 1;
        // and put it the first code line on the Ctor

        // if the Ctor take parameter id and assign it value to the id attribute
        // Ctor(int ID){
        //  id = 1;
        //  id = ID
        // } that will happen

        int currentSpeed;

        string model;

        // if no defined any Contructor : 
        // the compiler will generate empty parameterless Constructor {do no thing}
        //public Car() {}// that the compiler will define it

        // if define any Contructor the compiler will not define the Parameterless Ctor

        // it can overload on ctor
    }
}
