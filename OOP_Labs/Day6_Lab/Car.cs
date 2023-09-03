using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Lab
{
    internal class Car:IVeicle,IDrivable
    {
        //Fields
        private int starting_GasolineAmount;

        //Property
        public int Starting_GasolineAmount
        {
            get { return starting_GasolineAmount;}
            set
            {
                if(value>0)
                    starting_GasolineAmount = value;
                else
                    starting_GasolineAmount = 0;
            }
        }

        // Constructor
        public Car(int gasolineAmount)
        {
            if(gasolineAmount > 0)
                starting_GasolineAmount= gasolineAmount;
            else
                starting_GasolineAmount = 0;
        }

        //default Constructor
        public Car():this(0)
        { }

        //Methods
        public void driveType()
        {
            if(starting_GasolineAmount > 0)
            {
                Console.WriteLine("Car is Driving");
            }
        }

        public bool Refual(int gasolineAmonunt)
        {
            return (starting_GasolineAmount==0)?:false;
        }

        void IDrivable.MoveType()
        {
            throw new NotImplementedException();
        }

        void IDrivable.AccelerateType()
        {
            throw new NotImplementedException();
        }

        void IDrivable.DriveType()
        {
            throw new NotImplementedException();
        }
    }
}
