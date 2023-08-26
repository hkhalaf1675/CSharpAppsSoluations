using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3Lab
{
    internal class Person
    {
        protected int _id;
        protected string _name;

        protected void Display()
        {
            Console.Write("ID : {0}, Name : {1}", _id, _name);
        }
    }
}
