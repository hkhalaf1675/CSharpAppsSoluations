using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ExceptionHandling
{
    internal class Employee : IComparable
    {
        // attributes
        int id;
        string fullname;
        decimal salary;

        // properties
        public int ID
        {
            get { return id; }
            set
            {
                if(id != value)
                    id = value;
                
            }
        }
        public string FullName
        {
            get { return fullname; }
            set
            {
                fullname = value.Length > 20 ? value.Substring(0, 20) : value;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value > 5000 ? value : 5000;
            }
        }

        //Constructors
        public Employee(int id,string fullname, decimal salary)
        {
            this.id = id;
            this.fullname = fullname;
            this.salary = salary;
        }
        //default constructor
        public Employee():this(1,"Hassan Tawfik" , 7000M)
        {}

        //functions
        public override string ToString()
        {
            return $"Id : {id} , Full Name : {fullname} , Salary : {salary}";
        }
        public int CompareTo(object obj)
        {
            Employee right = obj as Employee;
            return salary.CompareTo(right.salary);
        }
    }
}
