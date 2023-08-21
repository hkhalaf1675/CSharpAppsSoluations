using System.Linq;

namespace Day2_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sumof2DArrayon3D
            //int[,] arr = new int[3, 3];
            //for(int i=0; i<3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    arr[i, 2] = arr[i, 0] + arr[i, 1];
            //}
            //for (int i = 0; i<3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //        Console.Write(arr[i, j] + " ");
            //    Console.WriteLine();
            //}
            #endregion

            #region frequency
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

            #region removeNonAlphabet
            //Console.Write("Enter your String :");
            //string str = Console.ReadLine();

            //char[] chars = str.ToCharArray();//convert string to array of chars
            //Array.Sort(chars);//sort the array to make not alphbet first

            //int firstAlphbetCharIndex = 0;//to get the first alphabet index on array

            //for(int i=0; i<chars.Length; i++)
            //{
            //    if (((int)chars[i] >= 65 && (int)chars[i] <= 90) || ((int)chars[i] >= 97 && (int)chars[i] <= 122))
            //    {
            //        firstAlphbetCharIndex = Array.IndexOf(chars, chars[i]);
            //        break;
            //    }

            //}
            //List<char> alphabetChars = chars.ToList();//tto convert array to list to use remove range
            //alphabetChars.RemoveRange(0, firstAlphbetCharIndex);//remove all chars from first to the fisrt alphabet char

            //Console.WriteLine(alphabetChars.ToArray());//print the result
            #endregion

            #region anotherSolutionToremoveNonAlphabet
            //Console.Write("Enter your String :");
            //string str = Console.ReadLine();

            //List<char> chars = str.ToList();//convert the string to list of chars
            //Console.WriteLine(chars.ToArray());

            //for (int i=0; i<chars.Count; i++)
            //{
            //    if (((int)chars[i] >= 65 && (int)chars[i] <= 90) || ((int)chars[i] >= 97 && (int)chars[i] <= 122))
            //    {

            //    }
            //    else
            //    {
            //        chars.RemoveAt(i);
            //    }
            //}
            //Console.WriteLine(chars.ToArray());
            //Console.WriteLine((int)'!');
            #endregion

            #region returnArrayMax
            //Console.Write("Enter the array length : ");
            //int l = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter array numbers and between each two numbers click enter : ");

            //int[] numbers = new int[l];
            //for (int i = 0; i < l; i++)
            //    numbers[i] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Max Number is : " + maxNumber(numbers));


            //static int maxNumber(int[] numbers)
            //{
            //    return numbers.Max();
            //}
            #endregion

            #region arrayMultiply
            Console.Write("Enter the array length : ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter array numbers and between each two numbers click enter : ");

            int[] numbers = new int[l];
            for (int i = 0; i < l; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            arrayMultiply(numbers);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            static void arrayMultiply(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] *= 10;
            }
            #endregion
        }
    }
}