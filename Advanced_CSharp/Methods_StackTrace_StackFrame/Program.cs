using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_StackTrace_StackFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string special
            //Console.WriteLine("/**\\");
            //Console.WriteLine(@"/**\");
            #endregion

            #region Method Calling
            PrintLine();
            Console.WriteLine("-------------");
            PrintLine(5, '*');
            Console.WriteLine("-----------------------");
            PrintLine(3.2);
            Console.WriteLine("-------------------");
            PrintLine(ch:'+');
            Console.WriteLine("-------------------");

            int x = 5;
            int y = 7;
            Console.WriteLine($"Before Swaping => X : {x} , Y : {y} ");
            //Pass by Value
            SwapByValue(x, y);
            Console.WriteLine($"After Sawping useing by Value => X : {x} , Y : {y}");
            SwapByRef(ref x,ref y);
            Console.WriteLine($"After Using Swap by Refernce => X : {x} , Y : {y}");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Method read and write variables : ");
            //be refernece
            int a = 5, b = 6, sum = 0, multi = 1;
            GetSumMult(a, b, ref sum, ref multi);
            Console.WriteLine($"SUm : {sum} , Mutli : {multi}");

            double s, m;
            GetSumMult(a, b, out s, out m);
            Console.WriteLine($"SUm : {s} , Mutli : {m}");

            //sentance suger
            GetSumMult(a, b, out double ss, out double mm);
            Console.WriteLine($"SUm : {ss} , Mutli : {mm}");

            //if need one variable of the output vraibles
            GetSumMult(a, b, out _, out double mmm);
            Console.WriteLine($"Mutli : {mmm}");

            #endregion


            #region Stack Trace
            //StackTrace sTrace = new StackTrace();

            //StackFrame[] sFrames = sTrace.GetFrames();

            //for (int i = 0; i < sFrames?.Length; i++)
            //    Console.WriteLine(sFrames[i].GetMethod().Name);
            #endregion

            Console.ReadKey();
        }
        // can give the method parameter default value
        // but if the fisrt parameter gived a default value must the rest of parameters given a default value
        static void PrintLine(int num = 5, char ch = '#')
        {
            for (int i = 0; i < num; i++)
                Console.Write(ch);
            Console.WriteLine();
        }
        static void PrintLine(double num,char ch = '#')
        {
            for(int i=0; i<(int)num; i++)
                Console.Write(ch);
            Console.WriteLine();
        }

        #region Pass by value
        static void SwapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

            //the two variables are swaped but on the main method when call the Swap method 
            //the two parameters are not swaped only the copies on the swap method there are swaped
        }
        #endregion

        #region Pass By Reference
        static void SwapByRef(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

            // the two variables are swaped 
            // because the two parameter do not take copies but take the refernece
            // the change on value affect on the sending variables
            // variables must be initialized be default
            // these can read them or write

            //Console.WriteLine(x);
        }
        #endregion

        #region Read & Write Variables
        //by reference
        static void GetSumMult(int x,int y,ref int sum,ref int mult)
        {
            //all the variables send to the method must be intialized
            // because can use it on te function

            //Console.WriteLine(sum);


            sum = x + y;
            mult = x * y;
        }

        //by output
        static void GetSumMult(double x,double y ,out double sum , out double mult)
        {
            // can sent it without intialize
            // because it must be assigned to value
            sum = x + y;
            mult = x * y;
        }
        #endregion
    }
}
