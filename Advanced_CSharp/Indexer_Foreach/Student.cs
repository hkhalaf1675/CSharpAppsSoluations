using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Foreach
{
    internal class Student:IComparable
    {
        #region Fields
        int id;
        string name;
        float gpa;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float GPA
        {
            get { return gpa; }
        }
        #endregion

        #region Ctor
        public Student(int id, string name, float gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        } 
        #endregion

        #region Methods
        // override tostring : make it print the name of student and it's gpa
        public override string ToString()
        {
            return $"{name} : {gpa}";
        }
        //implementing of Icomparable Interface
        // that help on comparing between two student depend on gpa
        public int CompareTo(object obj)
        {
            if (obj is Student)
                return this.gpa.CompareTo(((Student)obj).gpa);
            else
                return -2;
        } 
        #endregion
    }
}
