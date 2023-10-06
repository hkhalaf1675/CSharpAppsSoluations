using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Entitis
{
    internal class School
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Department department { get; set; }

        public List<Teacher> teachers { get; set; }

        //public List<TeacherTransfer> TeacherTransferRelation { get; set; }
    }
}
