namespace Access_Modifiers_ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-->>Access Modifer
            //  --> it is keyword to determine visablity of code memeber that used access modofer on it
            //  --> or scope of code member
            //  --> all access modifer have the same rule and can every code member use it
            //  -->public : every one see it{on the sam eproject or on another project}

            //  -->internal : 
                        //--> every one on the same project see it { less dgree from public}

            //  -->private : 
                       //--> can only see it on the same class defined on it

            //best practice of access modifer : 
                                        // -> all variables of fieldes or class variables  always private

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

            // Static Class : all class member must be static also
                // --> can not make from it variables
                    // --> when we need to call the static class members we call it like we call Console
                    //  --> staticClass.classMember();
                // --> static class Constractor : 
                    // --> static staticClass(){....};
                    // --> the constractor called on the first call of the static class only
                    // but the constracor of non static class it is call on every new object of the class

            // variables scope
                //static members can not reach to non static member
                // --> class level : can see it on place on the class scope
        }
    }
}