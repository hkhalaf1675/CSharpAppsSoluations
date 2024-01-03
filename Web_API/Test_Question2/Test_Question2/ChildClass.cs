using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Question2
{
    internal class ChildClass:BaseClass
    {
        public ChildClass(int _id,string _name):base(_id,_name)
        {
            
        }

        public override string GetLastName()
        {
            string lastName = "";
            if(FullName.Split(' ').Length > 1)
                lastName = FullName.Split(" ")[1];
            return "Last Name : " + lastName;
        }
        public new string GetFirstName()
        {
            return "First Name : " + FullName.Split(" ")[0];
        }

        public int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        public float Sum(int num1,float num2)
        {
            return (float)num1 + num2;
        }
    }
}
