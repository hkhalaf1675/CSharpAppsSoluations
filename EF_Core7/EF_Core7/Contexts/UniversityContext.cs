using EF_Core7.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core7.Contexts
{
    internal class UniversityContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UniversityDB;Integrated Security=true;TrustServerCertificate=True");
        }

        public DbSet<Student> Students { get; set; }
    }
}
