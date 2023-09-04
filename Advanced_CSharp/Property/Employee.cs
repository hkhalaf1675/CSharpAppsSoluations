using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    // Poperty is Function
    // it is combine of two methods
    // can apply on it nay operation that applied on method :
    // can override  , virtual,abstract , static
    // but can not apply overload on it because : 
    //-----> the property can take only one parameter and with type of the attribute
    struct Employee
    {
        // the only advantage of using public access modifier is that it easy to use
        // can access the public flied on any place on the soluation
        // can read from it or write to it from any scope
        public int Id;
        //the disadvantage
        //-----------> can not filter the data that can assign to it
        // -----------> any one can access it

        // ---> the soluation of this disadvantes or problem is Encapsulation
        //- ------> by using setter and getter

        string _name;

        public string GetName()
        {
            return _name;
        }
        internal void SetName(string name)
        {
            // if the name is bigger than 20 char will take only the first 20 char
            _name = name.Length<= 20?name:name.Substring(0,20);
        }

        decimal _salary;

        // can use property :
        // to handle private attribute
        // can make the attribute read only by define only get
        // can make any condidtion on the data on writting on the attribute
        // can change the access level of getting or setting

        public decimal Salary
        {
            get { return _salary; }
            internal set
            {
                if (value < 2000)
                {
                    _salary = 2000;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        // the diff between full property and auto property
        // the both can make data read only
        // the both spearte the data diffnation {attribute} from it use by making it private

        // the full i need to define the attribute
        // the full i can do data viladtion on it {data control}

        // the auto can not be write only
        // the auto i do not define the attribute {the complier who do that}
        //--- and the attribute is private and hidden even on the developer
        //---- and can use or aaccess the attribute directly only by attribute
        // the auto can not do data validtion{data contraol } on it

        // if there an attribute i define it and i do not make on it data validation
        // the best practaice of it to be auto property

        // the best practice of all dervied attribute {that is computed on run time } is auto property

        // shorty cut to define full property : propfull then double click on tap
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        // the short cut for auto property is : prop and double click on tap
        public decimal NetSalary 
        {
            get { return _salary * 0.1M; } // the char M is to make the number decimal datatype 
        }

        public int DepartNum 
        { 
            set; 
        }


        public override string ToString()
        {
            return $"ID : {Id} , Name : {_name} , Salary : {_salary}";
        }
    }
}
