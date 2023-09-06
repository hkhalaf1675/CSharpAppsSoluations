using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TraineeSalaryException:Exception
    {
        public TraineeSalaryException(string Msg):base(Msg)
        { }
    }
}
