using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public class TwoItemOperation<T>
    {

        public T Sum(T num1,T num2) 
        {
            return (dynamic)num1 + (dynamic)num2;
        }

        public T Sub(T num1,T num2)
        {
            return (dynamic)num1 - (dynamic)num2;
        }

        public T Div(T num1, T num2)
        {
            return (dynamic)num1 * (dynamic)num2;
        }

        
    }
}
