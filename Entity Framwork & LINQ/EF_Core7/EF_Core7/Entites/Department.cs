using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.Entites
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Manager")]
        public int ManagerID { get; set; }
        [InverseProperty("Department2")]
        public Employee Manager { get; set; }

        [InverseProperty("Department")]
        public List<Employee> Employees { get; set; }

        #region if we use table per concrete class
        //public List<FullTimeEmployee> FullTimeEmployees { get; set; } = new List<FullTimeEmployee>();
        //public List<PartTimeEmployee> PartTimeEmployees { get; set; } = new List<PartTimeEmployee>(); 
        #endregion
    }
}
