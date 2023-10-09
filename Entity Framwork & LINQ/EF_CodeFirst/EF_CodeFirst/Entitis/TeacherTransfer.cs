using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Entitis
{
    internal class TeacherTransfer
    {
        public int ID { get; set; }
        public DateTime TransferDate { get; set; }
        public Teacher Teacher { get; set; }
        public School FromSchool { get; set; }
        public School ToSchool { get; set; }
    }
}
