using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Question2
{
    internal class BaseClass
    {
        int id;
        public string FullName;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public BaseClass(int _id, string _name)
        {
            id = _id;
            FullName = _name;
        }
        public string GetFirstName()
        {
            return FullName.Split(' ')[0];
        }
        public virtual string GetLastName()
        {
            return FullName.Split(' ')[1];
        }
    }
}
