using EFCodeFirstCore.ConfigrationsClasses;
using EFCodeFirstCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstCore.Contexts
{
    internal class EnterpriseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UniversityDB;Integrated Security=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configration on full time class
            modelBuilder.Entity<FullTimeEmployee>(E =>
            {
                E.Property(F => F.Salary)
                .HasColumnType("money");

                E.Property(F => F.Address)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            });

            // apply the employee class configartions
            modelBuilder.ApplyConfiguration(new EmployeeConfigration());

            // apply the table per Hierarchy
            modelBuilder.Entity<FullTimeEmployee>()
                .HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<Employee>();

            // relationship one-to-one manger
            //modelBuilder.Entity<Department>()
            //    .HasOne(D => D.Manager)
            //    .WithOne(E => E.Department)
            //    .HasForeignKey("Employee", "ManagerSSN")
            //    .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Department>()
                .HasMany(D => D.Employees)
                .WithOne(E => E.Departments)
                .HasForeignKey(E => E.DeptID)
                .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
