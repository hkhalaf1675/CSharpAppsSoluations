using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.Percent(10,100));


            //Test.id == 5;//will give an error
            Console.WriteLine(Test.id);

            // test single tone class
            SingleToneClass stc1 = SingleToneClass.CreateObj();
            Console.WriteLine(stc1.GetHashCode());

            SingleToneClass stc2 = SingleToneClass.CreateObj();
            Console.WriteLine(stc2.GetHashCode());

            // test absrtact method
            InherClass inhC = new InherClass();
            inhC.Display();

            // inhertance
            Parent p = new Parent();
            Child c = new Child();

            c=(Child)p;
            Console.WriteLine(c.GetHashCode());
        }
    }

    static class Test
    {
        // static class : it is just a container to only static members
        // no objects can be created from it
        // can not inherit from it


        //int id;// will give an error
        // because all static class memebers must be static { all vaiable and methods }

        // and if you need to access member outside the class must be public static

        public static int id = 5;
        // if we can not assign value to that variable outside that class

        // can not access it outside that class
        static double PI()
        {
            return 3.14159265359;
            id = 10;
        }

        // can access it outside the class
        public static float Percent(float value, float total)
        {
            id = 15;
            float result = value / total;
            return result * 100;
        }

        // can only create static ctor
         static Test()
        {
            
        }

        // can not create any other ctor 

    }

    class SingleToneClass
    {
        // it design pattren : one of the 23 is single tone class
        // it class that create one instance and any object created from that class refer to the same instance 
        // how does do that

        // 1- firstly create private Ctor that can access it only on that class
        // 2- then create static memeber on that class of type same class
        // 3- then create method that access private Ctor and create new object { on the class memeber }
        // but must check if that member do not assigned before
        // to make the class can class it the method must be public static

        // class attributes or fields
        int id;
        string name;

        // 1- first step { private class }
        SingleToneClass()
        {
            id = 0;
            name = "single tone";
        }

        // 2- second step { class member on type same class}
        static SingleToneClass stc;

        // 3- thrid step { create the method that create the object }
        public static SingleToneClass CreateObj()
        {
            if (stc == null)
                stc = new SingleToneClass();
            return stc;
        }

        // there is another way to define that object by static Ctor
        // the static Ctor run one time 
        // so it will create the object on the first use the class
        static SingleToneClass()
        {
            stc = new SingleToneClass();
        }

        public static SingleToneClass CreateObject()
        {
            return stc;
        }

        // there another way by using Property
        public static SingleToneClass obj { get; } = new SingleToneClass();
    }



    #region Test OOP EXam
    abstract class AbstClass
    {
        public void Display()
        {
            Console.WriteLine("From Abstract");
        }
    }

    class InherClass : AbstClass
    {

    }

    class Parent
    {

    }
    class Child : Parent
    {

    }

    interface IMove
    {
        void Forward();
    }
    interface IFly
    {
        void Forward();
        void Up();
    }

    abstract class Vehicle : IMove, IFly
    {
        void IMove.Forward() { }

        void IFly.Forward()
        {
            throw new NotImplementedException();
        }

        void IFly.Up()
        {
            throw new NotImplementedException();
        }
    }

    class Plane : Vehicle
    {

    } 
    #endregion
}
