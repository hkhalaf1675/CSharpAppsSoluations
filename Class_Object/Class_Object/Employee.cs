using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    internal class Employee
    {
        // class attributes
        public int Emp_ID;
        public string Employee_Name;
        public int Employee_Age;
        private int Experience;
        public int Salary;

        //first constractor dedault
        public Employee() {
            Emp_ID = 0;
            Employee_Name = "name";
            Employee_Age = 0;
            Salary = 0;
            Experience = 0;
        }

        //paramterized constractor
        public Employee(int id, string name,int age, int expr, int salary)
        {
            Emp_ID = id;
            Employee_Name = name;
            Employee_Age = age;
            Experience = expr;
            Salary = salary;
        }

        // copy constractor
        public Employee(Employee E)
        {
            Emp_ID = E.Emp_ID;
            Employee_Name = E.Employee_Name;
            Employee_Age = E.Employee_Age;
            Experience = E.Experience;
            Salary = E.Salary;
        }

        //memeber function : method that display the data of empoyee
        public void display()
        {
            Console.WriteLine($"Employee Id : {Emp_ID}, Empoyee Name : {Employee_Name} , Employee Age : {Employee_Age} , Experience : {Experience} , Salary : {Salary}");
        }

        // member function to calculate bouns
        public double Emp_Bouns()
        {
            double bouns = Salary * 0.10 * Experience;
            return bouns;
        }


        //shallow copy constractor
        public object shallowConpy()
        {
            return this.MemberwiseClone();
        }
    }

    
}
