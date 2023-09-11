using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // delegate is a referance type
            // refere to a function
            // it use to sent a function as a parameter
            // the delegate and the function that can sent as a delegate must be the same signature
            // like if the function is of type bool and take one parameter
            // then the delegate must be bool and take on parameter

            // if there one function it will be used one time : it not important to define it
            // it can be anonymous type or object or lamada expression

            #region Lamada Expression {Anonymous function or one use function}

            //delegate (int num) { return num > 5; } //it is not important to write delegate
            //(int num){ return num > 5; } // if it is one parameter : it is not important to ()
            //// --> (int num1 , int num) {} // if there are more than one parameter it must use ()
            //int num { return num > 5; } // if the function is return function : not important to use return keyword
            //int num { num > 5; } // if the type of parameter is the type on the function I sent to it the delegate : so it is not important to write the type
            //num { num > 5; } // if the body of the function is one statment : it is not important to write {} and ;
            //// --> num {num+=5;num>5;} // if there are more than one statment it must use {} and ;
            //num num > 5 // to spearte between the paramtere and the body we use arrow =>
            //num => num > 5; 
            #endregion

            // Multi cast  delegates
            // it is the delegate that can take more than one function
            // del = func1
            // del += func2
            // del -= func2 // remove function from delegate
            // multi cast delegate is a list of methods run auto when invoke the delegate

            // built in delegate
            // 1- Predicate<Type of input parameter> and it is boolean return
            // 2- Func<type on input para,type of return type> // can take till 16 input parameter with diff types
            // 3- Action do not take any paramters and do not return it is void function
            // 3- Action<type of input param> take till 16 of diff input parameters and it is void function
        }
    }
}
