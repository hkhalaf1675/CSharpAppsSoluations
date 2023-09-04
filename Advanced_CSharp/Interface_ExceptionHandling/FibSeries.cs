using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ExceptionHandling
{
    internal class FibSeries : ISeries
    {
        int current;
        int prv;
        public int Current { get { return current; } }

        public FibSeries()
        {
            prv = 0;
            current = 1;
        }

        public void GetNext()
        {
            int temp = current;
            current += prv;
            prv = temp;
        }

        public void Reset()
        {
            prv = 0;
            current = 1;
        }
    }
}
