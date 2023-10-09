using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.Entites
{
    internal class StudentCourse
    {
        // the primary key is compoiste PK on Fluent APIs on Context class

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public float Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
