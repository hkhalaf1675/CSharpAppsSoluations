using EF_Core7.ConfigrationsClasses;
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
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.;Initial Catalog=UniversityDB;Integrated Security=true;TrustServerCertificate=True",X => X.UseDateOnlyTimeOnly());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping Class To Table WithOut Create DbSet of that Class
            // to convert the class to table :
            modelBuilder.Entity<Department>().ToTable("Department");
            // to interact with that table :
            // ---->> context.Set<Department>
            // ---> so it is perfer to create DbSet
            // the other way to convert class to table is to create DbSet<class> 
            #endregion

            #region Create Table PK
            modelBuilder.Entity<Department>().HasKey(D => D.DeptID);
            // to make the deptID the primary key
            //modelBuilder.Entity<Department>().HasKey(nameof(Department.DeptID));
            // the other way to make the deptID primary key 
            #endregion

            #region Create Identity On Column
            modelBuilder.Entity<Department>()
                    .Property(D => D.DeptID)
                    .UseIdentityColumn(1, 2);
            // to make the column identity(1,2) start from 1 and increment by 2 
            #endregion

            #region Determine the type of column on database and the default value and length 
            modelBuilder.Entity<Department>()
                    .Property(D => D.Name)
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .HasDefaultValue("HR");
            // to determine the datatype of property when mapped to column i database
            // and determine the max length of it
            // and determine the default value of it 
            #endregion

            #region Data Annontation By Fluent APIs
            modelBuilder.Entity<Department>()
                    .Property(D => D.Name)
                    .HasAnnotation("Display", "Name=Department Name")
                    .HasAnnotation("MinLength", "2");
            // to make data annontation on property on class
            // it is usefull when yoy don't have the class source code 
            #endregion

            #region Easy To Use Fluent API n One Table With many annontations and configrations
            // there is an easy way to use fluent apis
            modelBuilder.Entity<Department>(D =>
            {
                D.ToTable("Department");
                D.HasKey(E => E.DeptID);
                D.Property(E => E.Name)
                .HasColumnType("varchar");
            }); 
            #endregion

            #region Apply 4th Way Mapping : Configration Class
            //// to apply fourth way
            //// configration class
            //modelBuilder.ApplyConfiguration(new FullTimeEmployeeConfigrations()); 
            #endregion

            #region reltions between classes one-to-many
            // mapping and deteremine the relations between class
            // one to many relationship between Department(One) and Employee(Many)
            // --> and make the default behavior of delete cascade
            //modelBuilder.Entity<Department>()
            //    .HasMany(D => D.FullTimeEmployees)
            //    .WithOne(E => E.Department)
            //    .HasForeignKey(E => E.DepartmentID)
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Department>()
            //    .HasMany(D => D.PartTimeEmployees)
            //    .WithOne(E => E.Department)
            //    .HasForeignKey(E => E.DepartmentID)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// we can make that relation by the other side of Employee
            //modelBuilder.Entity<Employee>()
            //    .HasOne(E => E.Department)
            //    .WithMany(D => D.Employees)
            //    .HasForeignKey(E => E.DepartmentID)
            //    .OnDelete(DeleteBehavior.Cascade); 
            #endregion

            #region Composite PK
            // create the compiste primary key of relation class between Student and Course
            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new { SC.StudentId, SC.CourseId });
            #endregion

            #region Many-to-Many Relationship
            //// create the relation many to many
            //modelBuilder.Entity<Student>()
            //    .HasMany(S => S.Courses)
            //    .HasMany(C => C.Students) 
            #endregion

            #region Mapping Table Per Hierarchy
            modelBuilder.Entity<FullTimeEmployee>()
                    .HasBaseType<Employee>();

            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<Employee>();
            #endregion

            //modelBuilder.Entity<Department>().ToView("ViewNameOnDatabase").HasNoKey();

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
