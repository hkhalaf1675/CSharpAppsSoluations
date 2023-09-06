namespace Class_Constructor
{
    // the defualt access modifer to any class or struct on the assemply file is : internal
    public class ComplexNumber
    {
        //assemply file is the project

        int realPart;// default is private {can not see it from outside that scope

        protected int imaginPart;//that can see on only the class that inherte from that class
                                 //thought on that assemply file or other outside assemply files

        internal int real;//that can see it only on the same assemly file

        public int imagin;//that can see it ony scope on the same soluation

        protected internal int realImagin; // that can see it on the same assemply file
                                           // and on the class that inhert from that class on outside

        protected private int imaginReal; // can see it only on the class that inhert from that class
                                            // and must be on the same assemply file

        public ComplexNumber()
        {
            real = 0;
            imagin = 0;
            realPart = 0;
            imaginPart = 0;
        }
    }

    class TestMod
    {
        public TestMod()
        {
            ComplexNumber cnum = new ComplexNumber();
            cnum.real = 0;//internal access modifer
            cnum.imagin = 0;//public access modifer
            
            // can see any of private or protected
        }
    }

    class TestMod2 : ComplexNumber
    {
        public TestMod2()
        {
            base.imaginPart = 0;// can see proteceted access modifer

            base.real = 0; // can see internal 

            base.imagin = 0;// can see public

            //but can not see private
        }
    }
    
    
}