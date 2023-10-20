using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        // generic is usefull that we write the code once an d the git complier detect the type and generate the code once
        // generic swap method that swap the data on two variables
        static void SwapGeneric<T>(ref T X, ref T Y)
        {
            // Not all operation valid to be heneric
            // like can not asign or initialize a value :-
            // X = 5;// will give an error

            // but can initialize by only value : default
            X = default;// true statment

            // valid with system.object
            Object o1 = Y; // true statment

            // can not do arthimatic operation (+ , - , * , /) :-
            //T Z = X + Y;// will give an error

            // can not do equality or comaprison operation ( == , > , < , !=) :-
            //if (X == Y) { }// will give an error

            // but can do equaltiy by using Equals :-
            if (X.Equals(Y)) { }

            // can GetHashCode , and GetType
            Console.WriteLine(X?.GetHashCode()??0);
            Console.WriteLine(X?.GetType());

            T temp = X;
            X = Y;
            Y = temp;
        }
        static void Main(string[] args)
        {
            
            int a = 5;
            int b = 10;
            Console.WriteLine($"A : {a} , B : {b}");

            SwapGeneric(ref a, ref b);

            Console.WriteLine($"A : {a} , B : {b}");

            Console.WriteLine("------------------");

            string str1 = "ABC";
            string str2 = "DEF";
            Console.WriteLine($"A : {str1} , B : {str2}");

            SwapGeneric(ref str1, ref str2);

            Console.WriteLine($"A : {str1} , B : {str2}");



        }
    }
}
