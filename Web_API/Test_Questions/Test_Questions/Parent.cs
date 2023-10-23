using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Questions
{
    public class Parent
    {
        private int id;
        public string name;

        public Parent(int _id, string _name)
        {
            id= _id;
            name= _name;
        }

        public override string ToString()
        {
            return $"{id} , {name}";
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public float Sum(float num1, float num2)
        {
            return num1 + num2;
        }
    }
}
