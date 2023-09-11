using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modiferss
{
    // the default access modeifer of any class or struct on the assemply file or peoject is : internal
    public class ComplexNumber
    {
        // when said assemply or mean the project

        //-->>Access Modifer
        //  --> it is keyword to determine visablity of code memeber that used access modifer on it
        //  --> or scope of code member
        //  --> all access modifer have the same rule and can every code member use it
        //  -->public : every one see it{on the sam eproject or on another project}

        //  -->internal : 
        //--> every one on the same project see it { less dgree from public}

        //  -->private : 
        //--> can only see it on the same class defined on it

        //best practice of access modifer : 
        // -> all variables of fieldes or class variables  always private

        int real; //default access modifer of any variable is private 
        // that can see it ont the same scope only {that mean scope}

        internal int imagin; // internal can see it on the same project { assemply file }

        public int numReal; // can see it on any place on the same soluation

        protected int numImagin;// can see it only on the same scope and the class that inherit from that class
        //------------------------>>> till that class on another assemply file { another project }

        internal protected int numImagin2;// internal scope + proteced scope
        // can see it the same assemply file plus on any class that inherit from that classs on another assemply file

        private protected int numReal2;//can see it on the class that inherit from that class on the same assemply file
        // that mean there is class inherit from that class on another assemply file can not see it
    }
}
