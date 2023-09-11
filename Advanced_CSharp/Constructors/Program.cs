using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor is spacial method on class
            // auto invoked : when create object of the class
            // it helps to assign intial values to the class  attribute
            // or can resvice parameters to those attributes

            // if there is no constructors on the class :
            // the complier create adefualt constructor :
            // that do not take any parameter and do not change on the default value of attributes

            // if we create constructor manually the complier do not create the default constructor

            // can create more than one construvtor but de diff on type or number of input parameters { overload principle }

            // types of constructors :
            // defualt ctor : take no araguments or parameters
            // paramterized ctor : is the ctor that take at least on parameter
            // copy ctor : move the variables of object (instance) to another object
            // praviate ctor : it help to prevent creating object of the class
            // static ctor : it help to intialze static attributes or to do job or action one time
            // ----------->> it run auto when create the first object of the class { accutualy when write the class name }

            //Test t =new Test();// it will give error because there is no constructor create with that structure

            Console.WriteLine(Test.ItemsCount);
            Test t = new Test("hassan", 25);
            Console.WriteLine(t.name);
            Console.WriteLine(t.age);
            Test t2 = new Test(t);

            Console.WriteLine(Test.ItemsCount);
        }
    }


    class Test
    {
        public string name;
        public int age;
        static int TestItemCount;

        #region Parameterlized Ctor
        public Test(string name, int age)
        {
            // take at least on parameter
            this.name = name;
            this.age = age;

            TestItemCount++;
        }
        #endregion

        #region default Ctor
        public Test()
        {
            //take no araguments or parameters
            TestItemCount++;
        }
        #endregion

        #region Private Ctor
        private Test(int id)
        {
            // it help to prevent creating object of the class
            // can not access it from outside that class
            // can access it only on that class

            // to create object from that class : 
            // ----> we can create static method to create the object on the class
            // and it must be static to access it the class
            // if it not static will not do the creation
        }

        public Test CreateObject()
        {
            return new Test();// here we can access that private ctor
        }
        #endregion


        #region Copy Ctor
        public Test(Test t)
        {
            // move the variables of object (instance) to another object
            this.name = t.name;
            this.age = t.age;

            TestItemCount++;
        }
        #endregion

        #region Static Ctor
        static Test()
        {
            // static ctor : it help to intialze static attributes or to do job or action one time 
            // ----------->> it run auto when create the first object of the class { accutualy when write the class name }

            TestItemCount = 0;
        }
        #endregion

        public object ShallowCopy(Test t)
        {
            return this.MemberwiseClone();
        }

        public static int ItemsCount
        {
            get { return TestItemCount; }
        }
    }
}
