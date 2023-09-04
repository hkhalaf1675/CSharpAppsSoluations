using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    struct PhoneBook
    {
        string[] _name;
        long[] _number;
        int _size;

        public PhoneBook(int Size)
        {
            _size = Size;
            _name = new string[_size];
            _number = new long[_size];
        }

        public int Size
        {
            get { return _size; }
        }

        public long this[string Name]
        {
            get
            {
                for(int i=0; i<_number?.Length; i++)
                {
                    if (_name[i] == Name)
                        return _number[i];
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < _number?.Length; i++)
                    if (_name[i] == Name)
                        _number[i] = value;
            }
        }

        public long this[int index,string Name]
        {
            set
            {
                _name[index] = Name;
                _number[index] = value;
            }
        }

        public string this[int index]
        {
            get
            {
                return $"{_name[index]} , {_number[index]}";
            }
        }


    }
}
