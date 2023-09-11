using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract class can not create object from it
            // may be has abstract methods or not
            // but can not create abstract method on non abstract class
            // 
            // can not create abstract Ctor on abstract class
            // but can create Ctor on it
            // the benefit of it to initialize the base attributes
            // can intialize the base attributes on child class
            // but perefer to create Ctor on abstarct calss

            // the diff between Interface and Abstract class
            //
            // 1 - can implement more than one interface but can inherit from only one class
            // 2 - interface implementation valid on struct , but class inherit not valid on struct
            // 3 - interface can only contain abstract methods , but abstract class can contain any type of method
            // 4 - interface can not contain attributes { fields } , but abstract can contain fields

            //Shape sh = new Shape();// error can not create object from abstract class

            Shape line = new Line(5);
            Console.WriteLine(line.Area());
            line.ShowShape();

            Console.WriteLine("-------------------");

            Shape rect = new Rect(5, 4);
            Console.WriteLine(rect.Area());
            rect.ShowShape();
        }
    }

    abstract class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Shape(double x=0,double y=0)
        {
            X = x;
            Y = y;
        }

        public virtual double Area()
        {
            return X*Y;
        }

        public double GetDim1()
        {
            return X;
        }
        public abstract void ShowShape();
    }

    class Line:Shape
    {
        public Line(double x=1):base(x,0)
        { }

        public override void ShowShape()
        {
            Console.WriteLine($"X:{X}");
        }

        public override double Area()
        {
            return 0;
        }
    }
    class Rect : Shape
    {
        public Rect(double x = 1, double y=1):base(x,y)
        {  }

        public override void ShowShape()
        {
            Console.WriteLine($"X:{X} , Y:{Y}");
        }

        public new double GetDim1()
        {
            return Y;
        }

    }
}
