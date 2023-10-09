using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.Entites
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string? FullName { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }

        // relation one to many with the relation class
        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

        //// if the relation is many to many and there is no extra data
        //public List<Course> Courses { get; set; } = new List<Course>();
    }
}
