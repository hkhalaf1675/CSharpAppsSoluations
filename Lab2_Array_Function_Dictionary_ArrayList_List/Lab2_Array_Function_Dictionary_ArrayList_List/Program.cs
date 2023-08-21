using System.Collections;
using System.Collections.Generic;

namespace Lab2_Array_Function_Dictionary_ArrayList_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[,] numbers = new int[3,3];//the first array
            //int[,] numArray2 = new int[3,3];//the second array

            //int[,] sumRes = new int[3, 3];//the result of sum array

            //Console.Write("Enter the array numbers");
            //for(int i=0; i<3; i++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        numbers[i, j] = i;
            //        numArray2[i, j] = j;
            //        sumRes[i, j] = numbers[i, j] + numArray2[i, j];
            //    }
            //}
            // print the result
            //for(int i=0; i<3; i++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        Console.WriteLine($"{numbers[i, j]} + {numArray2[i, j]} = {sumRes[i, j]}");
            //    }
            //}
            #endregion

            #region Q2
            //int[,] arr = new int[,] { { 1, 2 },{ 3, 4 } };
            //int sum = 0;
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Sum is : {sum}");
            //Console.WriteLine("Averge : " + (sum / arr.Length));
            #endregion

            #region frequency
            //Console.Write("Enter the syatement : ");
            //string str = Console.ReadLine();

            //char[] chars = str.ToArray();//to take all chars from string
            //char[] distinctChars = chars.Distinct().ToArray();//to remove duplicated chars
            //char[,] charsCount = new char[distinctChars.Length, 2];//to make count the number of appears of every char
            //for (int i = 0; i < distinctChars.Length; i++)
            //{
            //    charsCount[i, 0] = distinctChars[i];//to save the char on the first col on array
            //    charsCount[i, 1] = char.Parse((str.Count(f => f == distinctChars[i])).ToString());//count char appearance times
            //}
            //for(int i=0; i<distinctChars.Length; i++)
            //{
            //    Console.WriteLine(charsCount[i,0]+" : appear : " + charsCount[i,1]+" times");
            //}
            #endregion

            #region Q4
            //Console.Write("Enter the string : ");
            //string str = Console.ReadLine();

            //List<char> strChars = str.ToList();
            //for(int i=0; i<strChars.Count; i++)
            //{
            //    //((int)strChars[i] >= 65 && (int)strChars[i] <= 90) || ((int)strChars[i] >= 97 && (int)strChars[i] <= 122)

            //    if (char.IsLetter(strChars[i]))
            //    {

            //    }
            //    else
            //    {
            //        strChars.Remove(strChars[i]);
            //    }
            //}
            //foreach(var ch in strChars)
            //{
            //    Console.Write(ch);
            //}
            #endregion

            #region returnArrayMax
            //Console.Write("Enter the array length : ");
            //int l = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter array numbers and between each two numbers click enter : ");

            //int[] numbers = new int[l];
            //for (int i = 0; i < l; i++)
            //    numbers[i] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Max Number is : " + maxNumber(numbers));

            #endregion

            #region arrayMultiply
            //Console.Write("Enter the array length : ");
            //int l = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter array numbers and between each two numbers click enter : ");

            //int[] numbers = new int[l];
            //for (int i = 0; i < l; i++)
            //    numbers[i] = int.Parse(Console.ReadLine());

            //arrayMultiply(numbers);

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region recursionSumFun
            //Console.Write("Enter the number :");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine(sumFrom_1_ToNum(num));
            #endregion

            #region GCD
            Console.Write("Enter The first Num : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter The second Num : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("CGD is : " + GCG(num1,num2));
            #endregion

        }

        static int maxNumber(int[] numbers)
        {
            return numbers.Max();
        }
        static void arrayMultiply(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] *= 10;
        }

        static int sumFrom_1_ToNum(int num)
        {
            if (num == 1)
                return 1;
            else
            {
                return num + sumFrom_1_ToNum(--num);
            }
        }

        static int GCG(int num1 , int num2)
        {
            int GCNum = 1;
            for(int i=2; i<Math.Min(num1, num2)+1; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                    GCNum = i;
            }
            return GCNum;
        }
    }
}