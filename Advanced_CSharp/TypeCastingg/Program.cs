using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Long max value : {long.MaxValue}");
            Console.WriteLine("Int max value : " + int.MaxValue);

            Console.WriteLine("--------------------");

            #region Implicit Casting
            // --> convert from datatype of large capacity ot datatype of smaller capacity
            // --> do not need to casting operators or use datatype to be casting operator
            // --> it is safe casting , no runtime error

            long lg = 50000;//int64 has capacity of 8byte
            int sm = 50;//int32 has capacity of 4byte

            Console.WriteLine($"lg : {lg} , sm : {sm}");
            Console.WriteLine("After casting ");

            lg = sm;

            Console.WriteLine($"lg : {lg} , sm : {sm}");
            Console.WriteLine("--------------------------------");
            #endregion

            #region Expicit Casting
            // --> convert from datatype of small capacity to datatype of larger capacity
            // --> must use casting operator to do the casting 
            // --> it is unsafe casting, may be data loss on it

            long lg2 = 500000123456789;
            int sm2 = 50;

            sm2 = (int)lg2;

            Console.WriteLine(sm2);
            Console.WriteLine(lg2);

            //to check if there is loss on data or overflow of explcit casting : use checked keyword
            // --> there is unchecked block used in checked block if there block of code i do not need to checked it
            long lg3 = 123456789123456789;
            int sm3 = 12345;

            try
            {
                checked
                {
                    sm3 = (int)lg3;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.WriteLine(sm3);
            Console.WriteLine(lg3);

            Console.WriteLine("--------------------");
            #endregion

            #region Nullable datatype

            // --> can not give value type the value NULL : 
            // -------------> because it the value of reference type

            //int n = null;//will throw error

            // --> if there col on database of type int and allow null
            // ---------------> may have null value
            // -------------> to make variable to save it there is nullable type : 

            Nullable<int> nullInt = null;
            nullInt = 50;// can save any int value addtional the null value

            int? intNull = null;
            intNull = 50;//the same of Nullable<int> datatype
            #endregion

            #region Casting from reference type to value type(boxing & unboxing)

            // --> there datatype or reference type called object
            // --> it is the parent of all datatype

            object o1 = new object();
            Console.WriteLine(o1);

            int x = 10;
            o1 = x; // can apply the casting 
            // --> any child class cast to parent class
            // --> that casting is safe cast
            // --> and called boxing
            // -------------> because it convert from value type to reference type
            // -------------> the actual action that object o1 leave the position and allocate new place on heap with the new value that come from stack

            Console.WriteLine(o1);

            // --> convert from object(reference type) to int(value type) :
            // -----------> it is unsafe
            // -----------> and called unboxing
            // -----------> and also take time to do the casting
            // -----------> and it must be Explicit casting and all disadvantages of explicit casting

            int y = (int)o1;
            Console.WriteLine("explicit casting to int : " + y);


            //bool b = (bool)o1;// will throw expection because the object have int value
            //Console.WriteLine("explicit casting to bool : " + b);

            o1 = "hello";
            //y = (int)o1;// will throw error because the object have string value

            // --> convert from value type to Nullable type 
            // --> implicit casting
            // --> safe 
            // --> do not need to casting operators

            int? numNull = 5;
            int num = 10;

            numNull = num;

            // --> convert from Nullable type to value type
            // --> explicit casting 
            // --> unsafe
            // --> must use casting operators


            // --------> Protective Programming
            if (numNull != null)
                num = (int)numNull;//
            else
                num = 0;

            // another way for protective
            if (numNull.HasValue)
                num = numNull.Value;
            else
                num = 0;

            //another way for protective using ternary operator
            num = numNull.HasValue ? numNull.Value : 0;

            //another way for protective belongs to Nullable datatype only
            num = numNull ?? 0;

            Console.WriteLine("------------------");
            #endregion

            #region default value

            //default value for all referenece types is null
            int[] arr = default;
            object obj = default;

            //defualt value for value types different from type to another
            int a = default;
            long l = default;
            float f = default;
            double d = default;
            bool c = default;
            char ch = default;

            Console.WriteLine($"Int default : {a} , Long : {l} , Float : {f} , Double : {d} , Bool : {c} , Char : {ch}");
            #endregion

            Console.ReadKey();
        }
    }
}
