using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class GList<T>
    {
        //attributes
        T[] arr;
        int size;
        int index;

        //Ctor
        public GList(int Size)
        {
            arr=new T[Size];
            size=Size;
            index = 0;
        }

        //Methods
        public void Add(T item)
        {
            arr[index++] = item;
        }
        public T Remove()
        {
            return arr[--index];
        }

        //return last number
        public T LastItem()
        {
            return arr[index-1];
        }

        // return first item
        public T FisrtItem()
        {
            return arr[0];
        }

        //return Item depend on Index
        public T Item(int index)
        {
            if (index < size)
                return arr[index];
            else
                throw new IndexOutOfRangeException();
        }
    }
}
