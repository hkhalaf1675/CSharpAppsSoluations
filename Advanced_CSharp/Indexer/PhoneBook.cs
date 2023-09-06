using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    struct PhoneBook:IEnumerable//to make struct use foreach
    {
        #region Fields
        string[] _name;
        long[] _number;
        int _size;
        #endregion

        #region Constructor
        public PhoneBook(int Size)
        {
            _size = Size;
            _name = new string[_size];
            _number = new long[_size];
        } 
        #endregion

        #region Properties
        public int Size
        {
            get { return _size; }
        }

        //indexer properties

        // take one input parameter string {name} and return the number
        public long this[string Name]
        {
            get
            {
                for (int i = 0; i < _number?.Length; i++)
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

        // write only indexer
        // take two input parameters index intger,name string and create new item depend on name the value{number}
        public long this[int index, string Name]
        {
            set
            {
                _name[index] = Name;
                _number[index] = value;
            }
        }

        //read only indexer
        //take one input parameter index integer and return the name the number on that index on array
        public string this[int index]
        {
            get
            {
                return $"{_name[index]} , {_number[index]}";
            }
        }

        #endregion

        #region Methods
        //implementing IEnumberable Interface
        // the benfit of using IEnumberable Interface is to make that struct using foreach
        //foreach depened on the GetEnumerator Function
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Inner Class That Help on GetEnumberator Function
        public class Iteration
        {
            
        }
        #endregion
    }
}
