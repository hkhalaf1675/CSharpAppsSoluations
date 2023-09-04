using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NegativeNumberException:Exception
    {
        public NegativeNumberException():base("Negtive Number ( the number must be more than 0)")
        { }
    }
}
