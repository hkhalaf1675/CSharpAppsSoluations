using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.Entites
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // relation one to many with the relation class
        public List<StudentCourse> CourseStudents { get; set; } = new List<StudentCourse>();

        //// if the relation is many to many and there is no extra data
        //public List<Student> Students { get; set; } = new List<Student>();
    }
}
