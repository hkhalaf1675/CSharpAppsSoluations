using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2, 2);
            point.CheckUp();
            Console.WriteLine(point.ToString());
            Console.WriteLine(point.Product());

            Console.WriteLine("-----------------------");

            Point3D p3D = new Point3D(2, 2, 2);
            p3D.CheckUp();
            Console.WriteLine(p3D.ToString());
            Console.WriteLine(p3D.Product());

            Console.WriteLine("---------------------------");

            Point point3D = new Point3D(3, 3, 3);
            point3D.CheckUp();
            Console.WriteLine(point3D.ToString());
            Console.WriteLine(point3D.Product());

            Console.WriteLine("-------------------------------");

            Point pointLine = new Line();
            pointLine.CheckUp();
            Console.WriteLine(pointLine.ToString());
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x=1, int y=1)
        {
            X = x;
            Y = y;
        }
       

        public override string ToString()
        {
            return $"X:{X} , Y:{Y}";
        }

        public int Product()
        {
            return X * Y;
        }

        public virtual void CheckUp()
        {
            if(Y>0)
                Console.WriteLine("The Point is Up");
            else
                Console.WriteLine("The Point is Not Up");
        }
    }

    class Point3D : Point
    {
        public int Z { get; set; }
        public Point3D(int x = 1,int y = 1,int z = 1):base(x,y)
        {
            Z = z;
        }

        // the base keyword is avaiable only on the child class
        // can not use it with objects

        // Hide the Parent Method
        // can do that with use new keyword or without it

        public new int Product()// here we can use new or not it is the same action
        {
            //return X * Y * Z;

            // another way 
            return base.Product() * Z;
        }

        public override string ToString()
        {
            return $"X:{X} , Y:{Y} , Z:{Z}";
        }

        public override void CheckUp()
        {
            if(Y>0 && Z>0)
                Console.WriteLine("The Point3D is Up");
            else
                Console.WriteLine("The Point3D is not Up");
        }
    }

    class Line : Point3D
    {
        // the new keyword prevent overriding of the method { remove the virtual keyword from that class }
        // the virtual keyword make the method can be overriding to any class will inherit from that class
        public override sealed/*virtual*/ void CheckUp()
        {
            Console.WriteLine("Line is UP");
        }
    }

    class Rect : Line
    {
        public  void Checkup()
        {

        } 
    }
}
