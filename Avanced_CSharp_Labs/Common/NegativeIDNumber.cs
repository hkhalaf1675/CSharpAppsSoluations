using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class NegativeIDNumber:Exception
    {
        public NegativeIDNumber():base("Negative ID number , it must be more than 0!")
        { }
    }
}
