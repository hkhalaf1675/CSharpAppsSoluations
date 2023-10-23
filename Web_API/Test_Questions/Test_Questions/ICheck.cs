using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Questions
{
    internal class ICheck
    {
        int ID { get; set; }
        string HashID { get => string.Concat("abh",ID); }
    }
}
