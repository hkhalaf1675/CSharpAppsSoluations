using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Entitis
{
    internal class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public long NationalID { get; set; }
        public string Code { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Qualification { get; set; }
        public DateTime QualificationDate { get; set; }
        public DateTime HiringDate { get; set; }
        public Address TeacherAddress { get; set; }
        public string Notes { get; set; }

        public School TeacherSchool { get; set; }

        //public List<TeacherTransfer> TeacherTransferRealtion { get; set; }

    }
}
