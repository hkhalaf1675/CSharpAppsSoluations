using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Entitis
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<School> schools { get; set; }
    }
}
