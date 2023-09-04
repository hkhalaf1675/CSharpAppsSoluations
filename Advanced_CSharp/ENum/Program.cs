using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENum
{
    // Can not declare the enum on any method
    // the best place to declare the enum is on the scope of namespace

    // it is data type of like class or struct
    // it is value type like struct
    // contain some of static values that used it on the progrram

    // the enum is rename of some integer values
    // the values that stored on memory is intger values from 0 to the number of enum values {indexes}

    // the enum values are intger variable that takes 4bytes on memeory
    // can change the size of enum on memeory to be short or to be long

    // can change the index of enum 
    // this will be usefull when working with data to save each value with each id
    enum Branches:byte// that is not inhertance but it is to make the enum know the datatype will use to declare memeory
    {
        SmartVillage = 105, Assuit = 106, Sohag = 120, Mansoura//will auto get it the number after the last index
    }

    enum laragEnum : long
    {

    }
    //enum charEnum : char { }// will give error
    //enum flostEnum : float { }//will give an error elso
    // the only type of data that enum can use is numeric datatype and integer not double or float or decimal

    // like
    // sbyte : -128:128
    // byte : 0:255
    // short : 16bit , 2byte
    // int : 32bit , 4byte

    //enum byteEnum : sbyte // will giva an erro on the BB : because it index will be 128 { out of range }
    //{
    //    AA = 127, BB ,CC ,DD
    //}

    // can store with out arrangment 
    // can use repeadted index

    [Flags]
    enum Permissions
    {
        read = 0X00 , write = 5 , excute = 0b_0000_0010
    }


    internal class Program
    {
        enum Grades
        {
            A, B, C
        }
        static void Main(string[] args)
        {
            int x = (int)Grades.A;
            Console.WriteLine(Grades.A);
            Console.WriteLine($"the code of Char A is {(int)'A'}");
            Console.WriteLine(x);

            Grades chB = Grades.B;
            Console.WriteLine((int)chB);

            //chB = 2;// can not implicit casting of the grades

            //but can explicit casting
            chB = (Grades)2;// will store the thrid value on Enum (c)
            Console.WriteLine("Explicit : " + chB);

            chB = (Grades)3;//will store num 3 because no value on the index num 3 on enum
            Console.WriteLine(chB);

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{Branches.SmartVillage} : {(int)Branches.SmartVillage}");

            Console.WriteLine(typeof(Branches));

            Console.WriteLine($"{Branches.Sohag} : {Branches.Sohag.GetHashCode()}");//will output the index of it
            Console.WriteLine($"{Branches.Assuit} : {Branches.Assuit.GetHashCode()}");

            Console.WriteLine($"{Branches.Mansoura} : {(int)Branches.Mansoura}");
            Console.WriteLine($"{Branches.Mansoura} : {Branches.Mansoura.GetHashCode()}");

            Grades s = Grades.A;
            Console.WriteLine(s);
            Console.WriteLine((int)s);
            Console.WriteLine(((int)s).GetHashCode());
            Console.WriteLine("---------------");
            Console.WriteLine($"{Permissions.read} : {(int)Permissions.read}");

        }
        static void test()
        {

        }
    }
}
