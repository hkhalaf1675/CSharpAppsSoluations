using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Student : IComparable
    {
        //Fields
        int id;
        string name;

        #region Properties
        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
                else
                {
                    // handle and throw new type of error
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value.Length > 20 ? value.Substring(0, 20) : value;
            }
        }
        #endregion


        #region Ctor
        public Student(int Id, string Name)
        {
            if (Id > 0)
                id = Id;
            else
            {
                throw new NegativeIDNumber();
            }
            name = Name.Length > 20 ? Name.Substring(0, 20) : Name;
        }

        //default ctor
        public Student() : this(1, "Hassan Tawfik")
        { } 
        #endregion

        // Methods or Functions
        public int CompareTo(object obj)// it will compare with the ID
        {
            if(obj is Student)
            {
                return id.CompareTo(((Student)obj).id);
            }
            else
            {
                throw new NotTheSameDataType();
                return -2;
            }
        }

        public override string ToString()
        {
            return $"ID : {id} , Name : {name}";
        }
    }
}
