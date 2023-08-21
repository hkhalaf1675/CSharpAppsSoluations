using System.Reflection.PortableExecutable;

namespace testProject_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int y=0; y<5; y++)
            {
                int[,] arr = new int[3, 3];
                Console.WriteLine("Enter the box numbers : ");
                for(int i=0; i<3; i++)
                {
                    for(int j=0; j<3; j++)
                    {
                        arr[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                //checked that it is Magic box or not
                int sum = 0;
                bool f = false;
                int sumCol_1 = 0, sumCol_2 = 0, sumCol_3 = 0;
                int mainRoot = 0, subRoot = 0;
                for(int i=0; i<3; i++)
                {
                    sum = 0;
                    sumCol_1 += arr[i, 0];
                    sumCol_2 += arr[i, 1];
                    sumCol_3 += arr[i, 2];

                    for(int j=0; j<3; j++)
                    {
                        sum += arr[i, j];
                        if (i == j)
                            mainRoot += arr[i, j];
                        if (i + j == 2)
                            subRoot += arr[i, j];
                    }
                    if (sum == 9)
                        f = true;
                    else
                    {
                        f = false;
                        break;
                    }
                }

                if (f && sumCol_1 == 9 && sumCol_2 == 9 && sumCol_3 == 9 && mainRoot == 9 && subRoot == 9)
                {
                    Console.WriteLine("it is magic box");
                }
                else
                    Console.WriteLine("not magic box");
            }
        }
    }
}