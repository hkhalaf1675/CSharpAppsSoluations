using EF_CodeFirst.Entitis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object from the context to work with database and it's tables
            DataContext context = new DataContext();

            // determine the streatgy that the EF will do it if the database is changed
            // there is alot if stratgis can the EF do 
            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());

            //  create new department
            Department dept1 = new Department()
            {
                ID = 1,
                Name = "Dept1"
            };

            // create new school
            School school1 = new School()
            {
                ID = 1,
                Name = "School1",
                department = dept1
            };

            // create new teacher
            Teacher teacher1 = new Teacher()
            {
                ID = 1,
                Name = "Teacher1",
                NationalID = 123456789,
                Code = "code1",
                Birthdate = DateTime.Now.AddYears(-22),
                HiringDate = DateTime.Now,
                Job = "Job1",
                Notes = "Notes1",
                Qualification = "Qualification",
                QualificationDate = DateTime.Now.AddYears(-3),
                TeacherAddress = new Address()
                {
                    ZipCode = 12345,
                    City = "City1",
                    State = "State1",
                    Country = "Country1"
                },
                TeacherSchool = school1
            };

            context.Teachers.Add(teacher1);

            try
            {
                context.SaveChanges();
                Console.WriteLine("Save Changes Successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
