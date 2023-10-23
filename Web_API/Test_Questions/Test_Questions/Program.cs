using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child(5, "name");
            Console.WriteLine(obj.ToString());
            string str = "HassAN";
            DDD(str);
            Console.WriteLine(str);

            int num1 = 10;
            int num2 = 0;
            try
            {
                Console.WriteLine(num1/num2);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("---");
            }
            catch (Exception ex)
            {
                Console.WriteLine("====");
            }
            finally
            {
                Console.WriteLine("finally");
            }

            String s1 = "ssssss";
            string s2 = "ssssss";
            string s3 = string.Concat(s1, s2);

        }
        public static void DDD(string name)
        {
            name = name.ToLower();
        }
    }
}
