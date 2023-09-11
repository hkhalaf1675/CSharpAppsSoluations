using System.Text;

namespace Access_Modifiers_ENUM
{
    internal class Program
    {
        public string _name = "hassan";
        static string _name2 = "outside method";
        static void Main(string[] args)
        {
            #region Access Modeifer
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
            #endregion

            #region Const and ReadOnly
            // Constants : that mean static value like {1hour have 60 minutes || i kilo have 1000 gram}
            // -> must be primative data type {int double,float,..} or string can not be class
            // --> name most used way is ALL_CAPS{that all chars is upper case and between
            // each two Words is _}
            // --> but on microsoft documentation said that PascalCase is the best way
            // {first char on each word upper}
            // --> the value of constants can not be changed
            // --> the value of constant must be declared and intialized on the same row of code
            //--> like public const PI = 3.4f;
            // --> on compile time {every use of the constant variable replace with it value}
            // so it called compile time constant

            // read-only variable : that mean i can read it value but can not change or write
            // or overwrite it's value
            // --> can declare the readonly variable on row without initialization it
            // -->  the only place can intialize the read only variable on Constractor of the class
            // {and can change the value of it on the constractor}
            // the value of read only variable called run time constant
            // { must the project work to know th value of readonly variable}
            // private readonly string str;
            //constracot(){ str = "abc";}
            // private readonly string str = "abc";
            #endregion

            #region Static Class
            // Static Class : all class member must be static also
            // --> can not make from it variables
            // --> when we need to call the static class members we call it like we call Console
            //  --> staticClass.classMember();
            // --> static class Constractor : 
            // --> static staticClass(){....};
            // --> the constractor called on the first call of the static class only
            // but the constracor of non static class it is call on every new object of the class
            #endregion

            #region Variable Scope
            // variables scope
            // scope mean all betwwen {}
            // static members can not reach to non static member
            // --> class level : can see it on place on the class scope : 
            // --> if on class there is vaiable { private or public } can not reacc to it on static function on the sam class
            // --> to reach to it you create object of the class and call it by the object
            //  --> if there are two vaibales with same name{i know that can not declare two vaiables with same name on the same scope}
            // --> but there is one on method and the other on outside the method but on the same class
            // --> on the method it will use the vaiable that declared on it
            // --> to use the other we can use {ClassName.VarName}

            // --> Method-Level scope : that can see the variables only on the method that declared on it


            //Console.WriteLine(_name); // it will give error 

            //Console.WriteLine(_name2);

            //string _name = "inside method";
            //Console.WriteLine(_name);
            //Console.WriteLine(Program._name2);//to call the outside variable

            //Program p1 = new Program();
            //Console.WriteLine(p1._name);

            #endregion

            #region Ref & Out
            // --> refernce type : like array and any class {work with memory addresses}
            // --> value type : like int ,float,double,... {work with value}

            // --> ref keyword : to use refernce with value type
            // --> must intialize the variable that wiil use the ref

            //int refNum; // we can not use ref with that because it not intializd

            //int refNum = 5;
            //Console.Write("Before use ref : ");
            //Console.WriteLine(refNum);

            //Console.Write("After use ref : ");
            //checkRef(ref refNum);//it will give error if we did not use ref becaues it must use ref
            //Console.WriteLine(refNum);


            // --> out keyword : it like ref with some different
            // --> out : the variable may intialize the variable or not
            // --> out : on the method must give the out variable value on the method

            //int outNum;
            //checkOut(out outNum);
            //Console.WriteLine(outNum);

            // there is method called tryParse{use with any value dataType} it is return true or false
            // true if it can parse 
            // false if can not parse

            //int n = 0;
            //bool f = int.TryParse(Console.ReadLine(), out n);

            //Console.WriteLine(n);

            #endregion

            #region String_Format
            //string str = "The First Name is : {0}, and the Second Name is : {1}";
            //str = string.Format(str, "Hassan", "Ahmed");
            //Console.WriteLine(str);

            //string str2 = "the first course is : {0}";
            //str2 = string.Format(str2, "OOP", "JavaScript");//there is vaiables more than needed{will ignore them}
            //Console.WriteLine(str2);

            //string str3 = "The Years is {0} , {1} , {2}";
            //str3 = string.Format(str3, "2023", "2022","2021");// can not use number of vaiables less than needed
            //Console.WriteLine(str3);

            // if we neeed to put spaces with the vaiables{you give the variable length
            //string str4 = "the name {0 , 17}"; //it will put the vaiable and the rest of length spaces after name
            //str4 = string.Format(str4, "Name for anybody");
            //Console.WriteLine(str4);

            // format is very usefull
            // --> can convert num to hexa
            //Console.WriteLine("Hexa Decimal for num 15 is");
            //Console.WriteLine($"{15:x}");

            // --> to convert num to double and determine the numbers after .
            // and can convert from double to int
            //Console.WriteLine($"152.12656 almost equal {152.12645:c2}");
            //Console.WriteLine($"152.12656 almost equal int num {152.12645:c0}");

            //Console.WriteLine($"{67812345.6789:N1}");
            //Console.WriteLine($"{12345.6789:0.0}");
            #endregion

            #region Split Join
            //Console.Write("Enter Numbers sperated with comma : ");
            //string strarr = Console.ReadLine();
            //string [] numarr = strarr.Split(",");
            //int sum = 0;
            //foreach (string str in numarr)
            //    sum += int.Parse(str);
            //Console.WriteLine("the Sum is equal is : " + sum);

            //Console.Write("Enter the word to remove the not alphabet frrom it : ");
            //string word = Console.ReadLine();

            //List<char> chars = word.ToList();

            //for(int i=0; i<chars.Count; i++)
            //{
            //    int chAscii = (int)chars[i];
            //    if ((chAscii < 65))
            //        chars.RemoveAt(i);
            //    else if (chAscii > 122)
            //        chars.RemoveAt(i);
            //    //else if (chAscii > 90)
            //    //    chars.RemoveAt(i);
            //    //else if ((chAscii < 97))
            //    //    chars.RemoveAt(i);
            //}
            //Console.WriteLine(string.Join("", chars));
            #endregion

            #region String Builder
            // string is immutable type : 
            // --> that mean it can not change the value on it
            // --> but on change it on the code the compiler take anew place on the memory
            // --> and put the new value on it and old value still in it's place 
            // --> to solve that problem there is string buider : 
            // --> it work using linked list , it is array of chars :
            // --> fisrt take 16bit and when it filled it take word or new text length or take new 16bit from the memory
            // --> it is slower than string
            // --> if we use string and there is no many operators on that text should use string
            // --> if there is many operators should use StringBuilder

            StringBuilder sb = new StringBuilder();// that take capacity 16bit and max capacity more than 20000000 from memory
            sb.Append("hassan");//add the text
            sb.AppendLine(" , after that new line");
            sb.Append("we are in the new line now");

            Console.WriteLine(sb.ToString());
            Console.WriteLine($"SB Length : {sb.Length}");
            Console.WriteLine($"Sb Capacity : {sb.Capacity}");
            Console.WriteLine("Max Capacity : " + sb.MaxCapacity);
            StringBuilder sb2 = new StringBuilder(4096); // that take capacity 4Mbit and the same max capacity


            #endregion

        }

        static void checkRef(ref int num1)
        {
            num1 += 10;
        }

        static void checkOut(out int num2)
        {
            num2 = 10;
        }
    }
}