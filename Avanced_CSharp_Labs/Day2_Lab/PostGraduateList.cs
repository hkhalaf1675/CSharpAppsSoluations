using Common;
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
        #region Fields
        PostGraduate[] students;//array of studnets
        int size;//take the number of students that will input there data
        int index;//to know the position of each iterator 
        #endregion

        #region Properties Indexers
        // take id and name na d the default will be the gpa on set
        // on get will check for only the gpa of student with that id
        public PostGraduate this[string name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (students[i].Name == name)
                        return students[i];
                    else
                        return null;
                }
                return null;
            }
            set
            {
                students[index++] = value;
            }
        }

        // will return the studnet that it's id equal the input parameter id
        public PostGraduate this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                if (index < size)
                {
                    students[index] = value;
                    this.index++;
                }
                    
            }
        }

        #endregion

        #region Ctor take only the size of array : number of students
        public PostGraduateList(int Size)
        {
            students = new PostGraduate[Size];
            this.size = Size;
            index = 0;
        }
        #endregion

        #region Methods
        // sorting students array method
        public void StudentSortGPA()
        {
            Array.Sort(students);
        }

        //implementing IEnumberable Interface
        // GetEnumberator return object of type IEnumerator : so we need a class that impement that interface
        public IEnumerator GetEnumerator()
        {
            return new Iteration(this);
        }
        #endregion

        #region Inner Class Iteration ENumertaor
        //Inner class that implement the IEnumerator Interface
        public class Iteration : IEnumerator
        {
            PostGraduateList list;
            int index;
            public Iteration(PostGraduateList list)
            {
                this.list = list;// make the Iteration refer to the List Parameter
                this.index = 0;
            }

            //implementing the IEnumertor Interface
            public object Current
            {
                get
                {
                    return this.list[index++];
                }
            }

            public bool MoveNext()
            {
                return this.index < this.list.index;
            }

            public void Reset()
            {
                this.index = 0;
            }
        }
    }
    #endregion
}

