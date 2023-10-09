using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIEntities context = new ITIEntities();

            //context.Database.Log = Console.WriteLine;

            #region Insert new Course
            Course newCrs = new Course()
            {
                Crs_Id = 1400,
                Crs_Name = "Entity Frameword",
                Crs_Duration = 3,
                Topic = context.Topics.FirstOrDefault()
            };

            context.Courses.Add(newCrs);
            context.SaveChanges();
            #endregion

            #region Update Course
            Course updateCrs = context.Courses.FirstOrDefault(C => C.Crs_Id == 1300);

            updateCrs.Crs_Name = "LINQ & EF";

            context.SaveChanges();
            #endregion

            #region Delete Course
            //Course delCrs = context.Courses.FirstOrDefault(C => C.Crs_Id == 1400);

            //context.Courses.Remove(delCrs);
            //context.SaveChanges();
            #endregion

            #region Stored Procedure
            var proc = context.NoOfStudentsPerDepartment(context.Departments.FirstOrDefault().Dept_Id).ToList();

            Console.WriteLine(proc[0].Dept_Number + " => " + proc[0].No_Of_Student);
            #endregion

            #region Concurrency
            ITIEntities context2 = new ITIEntities();

            var dur1 = context.Courses.FirstOrDefault().Crs_Duration;

            var dur2 = context2.Courses.FirstOrDefault().Crs_Duration;

            dur1 -= 40;

            context.SaveChanges();

            try
            {
                dur2 -= 10;
                context2.SaveChanges();
                Console.WriteLine("Done On try");
            }
            catch (DbUpdateConcurrencyException ex)
            {
                do
                {
                    var entires = ex.Entries.FirstOrDefault();
                    if (entires.GetType() == dur2.GetType())
                    {
                        context2.Entry(dur2).Reload();
                        dur2 -= 10;
                    }
                } while (context2.SaveChanges() <= 0);

                Console.WriteLine("Done on Catch");
            } 
            #endregion
        }
    }
}
