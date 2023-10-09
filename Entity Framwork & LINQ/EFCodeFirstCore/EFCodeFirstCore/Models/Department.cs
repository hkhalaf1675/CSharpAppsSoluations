using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstCore.Models
{
    internal class Department
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptID { get; set; }

        [Display(Name ="Department Name")]
        [Column(TypeName ="nvarchar")]
        [StringLength(50,MinimumLength = 2)]
        public string Name { get; set; }
        //[ForeignKey("Manager")]
        //public string? ManagerSSN { get; set; }

        //public Employee Manager { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
