using EF_CodeFirst.Entitis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    internal class DataContext:DbContext
    {
        public DataContext():base("name=EducationSystemConnectionString")
        { }

        public DbSet<Department> departments { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherTransfer> TeacherTransfers { get; set; }
    }
}
