using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Contructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c;//that allcate 0 byte on heap memory
           // Console.WriteLine(c.GetHashCode());// give get erro because there no initailze or assign on c
            c=new Car();
            Console.WriteLine(c.GetHashCode());

            Car car = new Car();//it will give error if there is ctor but take parameter
                                // and there is no ctor with no paramters
            Console.WriteLine(car.GetHashCode());

            Console.WriteLine("---- After = -----");
            car = c;
            // after that : the old ref od car will be unraechable
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(car.GetHashCode());

            // the new keyword it is the responsible of allocate the memory
            // it is allocate memory depend on the the members on the class

            // if there 3 attribute of data type int : it will allocate { 3 * 4byte = 12byte }
            // it will give these attributes the default values of there type { int default : 0}

            // the Car()  is responsible about:
            // the inialial values of attribute


        }
    }
}
