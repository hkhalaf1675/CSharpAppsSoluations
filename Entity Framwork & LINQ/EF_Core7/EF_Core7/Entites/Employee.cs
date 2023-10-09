using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.Entites
{
    internal class Employee
    {
        public int ID { get; set; }
        public string? FullName { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        [InverseProperty("Employees")]
        public Department Department { get; set; }
        [InverseProperty("Manager")]
        public Department Department2 { get; set; }
    }
}
