using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Question2
{
    internal interface ICheck:IEnumerable,IComparable
    {
        int ID { get; set; }
        int HashID { get => ID * 10; }
        int getNetSalary();
    }
}
