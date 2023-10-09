using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstCore.Models
{
    internal class Employee
    {
        public string SSN { get; set; }
        public string FullName { get; set; }
        public int? Age { get; set; }
        [ForeignKey("Departments")]
        public int? DeptID { get; set; }
        public Department Departments { get; set; }
        public Department Department { get; set; }
    }
}
