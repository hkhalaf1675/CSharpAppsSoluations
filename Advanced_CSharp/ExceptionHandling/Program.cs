using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the worst thing to do by developer is to not handle exception 
            // and the exception throw to the user

            // it can be handle any thing expected to throw exception by try & Catch

            // the paraent or all exception is Exception
            // there are several types of exception on c sharp

            // to write try catch
            // on the try blocks we put the code : try {code...}
            // and after the blocks of try we put the catch statment
            // the catch statment to catch the exception
            // catch( Exception ex){}
            // can write more than one catch statement
            // we put the parent exception on the last

            // we can use finally statment on the last of the code after of catch blcok
            // the finally will excute on all situations thougth it run without error or with error
            

            Console.WriteLine("Enter Intger Num");
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num <= 0)
                    throw new NegativeNumberException();
                else
                    Console.WriteLine(num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception");
                Console.WriteLine(ex.Message);
            }
            catch(NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Parent Exception");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block statment------------------");
            }

            // you must make the handle exception the last way 
            // you must write protective code to avoid all errors excepted

            // TryParse : is function return true or false
            // it do not throw exception if the parsing failed

            // we can it to handle expected errors on parsing data

            int X, Y, Z;
            do
            {
                Console.WriteLine("Enter the First Number and it must be intgere number : ");
            } while (!int.TryParse(Console.ReadLine(), out X));

            do
            {
                Console.WriteLine("Enter the Second Number and it must be intgere number : ");
            } while (!int.TryParse(Console.ReadLine(), out Y));

            Y = Y > 0 ? Y : 1;
            Z = X / Y;

            Console.WriteLine(Z);


        }
    }
}
