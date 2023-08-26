using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_OOP_Lab_2
{
    internal class Employee
    {
        static string _deptName;
        static int _empCount;

        #region Employee fields
        private long _empNID;
        private string _empName;
        private double _empSalary;
        private string _empTitle;
        private string _empAddress;
        #endregion

        #region Constractors
        // class constractor
        static Employee()
        {
            _deptName = "Department Name";
            _empCount = 0;
        }

        public Employee(long id,string name, double salary,string title,string address)
        {
            if (id.ToString().Length == 16)
                _empNID = id;
            else
                _empNID = 0;
            if (name.Length > 3)
                _empName = name;
            else
                _empName = "N/A";
            if (salary > 3000)
                _empSalary = salary;
            else
                _empSalary = 3000;
            
            _empTitle = title;
            _empAddress = address;

            _empCount++;
        }
        //constractor chaining
        public Employee():this(0,"N/A",3000,"","")
        {

        }


        #endregion

        #region properties

        public long NID
        {
            get { return _empNID; }
        }
        public string EmpName
        {
            get { return _empName; }
            set
            {
                if (value.Length > 3)
                    _empName = value;
                else
                    _empName = "N/A";
            }
        }
        public double Salary
        {
            get { return _empSalary; }
            set
            {
                if (value > 3000)
                    _empSalary = value;
                else
                    _empSalary = 3000;
            }
        }

        public string Title
        {
            get { return _empTitle; }
            set { _empTitle = value; }
        }

        public string Address
        {
            get { return _empAddress; }
            set { _empAddress = value; }
        }
        #endregion

        #region methods
        public static int DisplayCount()
        {
            return _empCount;
        }// can not call this function by object only be class
         // 
         public void DisplayEmpInfo()
        {
            Console.WriteLine($"Emp_NID : {_empNID}, EmpName : {_empName}, Salary : {_empSalary}, Title : {_empTitle}, Address : {_empAddress} , Department Name : {_deptName}");
        }

        #endregion
    }
}
