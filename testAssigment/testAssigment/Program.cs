

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Enter the number : ");
//    int num = int.Parse(Console.ReadLine());

//    Console.WriteLine(((char)num));
//}

//--------------------------------

//float floatNum = float.Parse(Console.ReadLine());
//Console.WriteLine(floatNum + " is type of :" + floatNum.GetType());

//--------------------------------

//Console.Write("Enter the two numbers : ");
//string str = Console.ReadLine();
//int num1 = Convert.ToInt32(str.Split(' ')[0]);
//int num2 = Convert.ToInt32(str.Split(' ')[1]);

//Console.WriteLine("the sum of {0} + {1} is equal : {2}",num1,num2 ,(num1+num2));

//--------------------------------

//Console.Write("Enter the number to know the quotient and remainder of it : ");
//int qnum = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter the divisor : ");
//int divisor = int.Parse(Console.ReadLine());

//Console.WriteLine("the quotient is {0} and the remainder is {1}",(qnum/divisor),(qnum%divisor));

//--------------------------------

//Console.Write("Enter the number to check if it even or odd : ");
//int checkNum = int.Parse(Console.ReadLine());

//bool f = (checkNum % 2 == 0) ? true : false;

//if(f)
//    Console.WriteLine("{0} is Even",checkNum);
//else
//    Console.WriteLine("{0} is Odd", checkNum);

//--------------------------------

//Console.Write("Enter the three numbers : ");
//int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//Console.WriteLine("the max number is : " + numbers.Max());

//--------------------------------

//Console.Write("Enter the dgree : ");
//char dgree = Convert.ToChar(Console.ReadLine());

//switch (dgree)
//{
//    case 'A':
//        Console.WriteLine("Excellent");
//        break;
//    case 'B':
//        Console.WriteLine("Very Good");
//        break;
//    case 'C':
//        Console.WriteLine("Good");
//        break;
//    case 'D':
//        Console.WriteLine("Fair");
//        break;
//    case 'E':
//        Console.WriteLine("Failed");
//        break;
//    default:
//        Console.WriteLine("Opps you entered char that is not dgree or on lowercase");
//        break;
//}

//--------------------------------

for(int i=0; i<5; i++)
{
    Console.Write("Enter the char : ");
    char ch = char.Parse(Console.ReadLine());

    if ((int)ch >= 65 && (int)ch <= 90)
        Console.WriteLine("Alphabet");
    else if ((int)ch >= 97 && (int)ch <= 122)
        Console.WriteLine("Alphabet");
    else
        Console.WriteLine("Not Alphabet");
}