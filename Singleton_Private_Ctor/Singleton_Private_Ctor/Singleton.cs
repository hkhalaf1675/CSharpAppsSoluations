using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Private_Ctor
{
    internal class Singleton
    {
        int id;
        string name;

        static Singleton singleton;

        private Singleton(int _id, string _name) 
        {
            id = _id;
            name = _name;
        }

        public static Singleton CreateObject(int _id, string _name)
        {
            if(singleton == null)
            {
                singleton = new Singleton(_id, _name);
                return singleton;
            }
            else
            {
                return singleton;
            }
        }
    }
}
