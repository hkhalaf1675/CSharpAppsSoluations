using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_2
{
    internal class Note
    {
        string name;
        string state;

        public Note(string _name , string _state)
        {
            name= _name;
            state= _state;
        }

        public override string ToString()
        {
            return $"Name : {name} , State : {state}";
        }

    }
}
