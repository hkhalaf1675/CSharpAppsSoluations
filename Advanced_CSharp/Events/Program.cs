using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Events : it is a group of items that interact with each others
            // Event consists  from :
            //--------> Publicher { Sender }
            //--------> Listener { Reciever }
            //--------> Subscribtion { relation between publisher and listener }

            // The Listener Must make way to recive the action or msg from Publisher
            // the way is a method on the Listener 

            // but here to send to listener we should use his method
            // and in real the publisher he is the responsible for that
            // so we will create a delegate with the same signature of the Listener method
            // and assign the Listener method to that delegate

           
                
        }

        
    }
}
