using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Lab
{
    internal class PostGraduateList:IEnumerable
    {
        //fields
        PostGraduate[] graduateList;
        int size;
        int index;

        //properties
        //indexer
        public PostGraduate this[int index]
        {
            get { return graduateList[index]; }
            set
            {
                if (index > size)
                    throw new IndexOutOfRangeException();
                else
                {
                    graduateList[index] = value;
                    index++;
                }
            }
        }

        //ctor
        public PostGraduateList(int Size)
        {
            graduateList = new PostGraduate[Size];
            size = Size;
            int index = 0;
        }

        //implementing IEnumberable Interface
        public IEnumerator GetEnumerator()
        {
            return new Iteration(this);
        }

        //----------------------------------->>> Inner Class <<<--------------//

        #region Iteration Inner Class
        //Inner Class to Iteration
        class Iteration : IEnumerator
        {
            //inner class fields
            int Iindex;
            PostGraduateList list;

            //ctor
            public Iteration(PostGraduateList list)
            {
                this.list = list;
                Iindex = 0;
            }

            //implementing the IEnumerator Interface
            public object Current
            {
                get { return list[Iindex++]; }
            }

            public bool MoveNext()
            {
                return Iindex > list.index;
            }

            public void Reset()
            {
                Iindex = 0;
            }
        } 
        #endregion
    }
}
