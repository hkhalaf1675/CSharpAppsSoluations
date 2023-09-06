using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class NotTheSameDataType:Exception
    {
        public NotTheSameDataType():base("Different Data Type !")
        { }
    }
}
