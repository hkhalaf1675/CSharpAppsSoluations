using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Lab
{
    internal class Employee
    {
        #region Fields
        int id;
        string name;
        int salary;
        string gender;
        int experience; 
        #endregion

        #region Propperties
        public int ID 
        {
            get { return  id; } 
            set { id = value; }
        }

        public string Name 
        {
            get { return name; }
            set {  name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Gender
        {
            get { return gender; }
            set {  gender = value; }
        }

        public int Experience 
        { 
            get { return experience; }
            set { experience = value; }
        }
        #endregion

        #region Ctors
        public Employee(int id, string name, int salary, string gender, int exprience)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.gender = gender;
            this.experience = exprience;
        }
        public Employee() : this(0, "Hassan", 5000, "Male", 6)
        { }
        #endregion

        public override string ToString()
        {
            return $"Name : {name} , Salary : {salary} , Exprience : {experience}";
        }

    }
}
