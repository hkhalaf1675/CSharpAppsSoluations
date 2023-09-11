using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3Lab
{
    internal class Employee:Person
    {
        static int EmployeesCount;
        protected int _age;
        protected string _certf;//can acces it on the class and by the childs of that class
        internal int exper;//can access it on the class or on the same project
        internal protected double salary;//can access it on the same project and by any child of the class even on the another project but the same soluation

        #region optional if the fields private
        //properties
        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}
        //public string Certf
        //{
        //    get { return _certf; }
        //    set { _certf = value; }
        //}
        #endregion

        public static int Count
        {
            get { return EmployeesCount; }
        }

        static Employee()
        {
            EmployeesCount = 0;
        }
        public Employee()
        {
            _id = 1;
            _name = "Hassan";
            _age = 25;
            _certf = "computer and information";
            exper = 3;
            salary = 5000;
            EmployeesCount++;
        }

        public void ShowData()
        {
            Console.WriteLine($"Name : {_name}, ID : {_id} , Age : {_age} , _certfication : {_certf}");
        }

        protected void Display()
        {
            base.Display();
            Console.WriteLine($" ,Age : {_age} , Certifcation : {_certf}");
        }

        public double GetBouns()
        {
            return salary * 0.1;
        }

        public void DeepCopy( Employee emp)
        {
            this._id = emp._id;
            this._name = emp._name;
            this._age = emp._age;
            this._certf = emp._certf;
            this.salary = emp.salary;
            this.exper = emp.exper;
        }
    }
}
