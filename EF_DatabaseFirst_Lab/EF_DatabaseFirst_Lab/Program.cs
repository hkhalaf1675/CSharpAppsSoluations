using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DatabaseFirst_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIEntities context = new ITIEntities();

            //context.Database.Log = Console.WriteLine;

            #region Insert new Course
            //Course newCrs = new Course()
            //{
            //    Crs_Id = 1400,
            //    Crs_Name = "Entity Frameword",
            //    Crs_Duration = 3,
            //    Topic = context.Topics.FirstOrDefault()
            //};

            //context.Courses.Add(newCrs);
            //context.SaveChanges();
            #endregion

            #region Update Course
            //Course updateCrs = context.Courses.FirstOrDefault(C => C.Crs_Id == 1300);

            //updateCrs.Crs_Name = "LINQ & EF";

            //context.SaveChanges();
            #endregion

            #region Delete Course
            //Course delCrs = context.Courses.FirstOrDefault();

            //Console.WriteLine(delCrs.Crs_Name);
            //context.Courses.Remove(delCrs); 
            //context.SaveChanges();
            #endregion

            var proc = context.NoOfStudentsPerDepartment(context.Departments.FirstOrDefault().Dept_Id);

            Console.WriteLine(proc.ToString());
        }
    }
}
