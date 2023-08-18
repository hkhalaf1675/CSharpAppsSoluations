

#region ASCIICode

Console.Write("Enter Char : ");
char ch = char.Parse(Console.ReadLine());
Console.WriteLine($"the ASCII code of {ch} is : {(int)ch}");

#endregion

#region floatVar

//Console.Write("Enter float num : ");
//float fNum = float.Parse(Console.ReadLine());
//Console.WriteLine(fNum);

#endregion

#region SunTwoNumbers

//Console.Write("Enter Two Number : ");
//string str = Console.ReadLine();
//int num1 = int.Parse(str.Split(' ')[0]);
//int num2 = int.Parse(str.Split(' ')[1]);
//Console.WriteLine($"the sum of {num1} + {num2} = {num1+num2}");

#endregion

#region HexaNumber

//Console.Write("Enter the number : ");
//int hexaNum = int.Parse(Console.ReadLine());
//Console.WriteLine($"{hexaNum:x}");

#endregion

#region Quotient&Remainder

//Console.Write("Enter Two Numbers : ");
//string str2 = Console.ReadLine();

//int num1 = int.Parse(str2.Split(' ')[0]);
//int num2 = int.Parse(str2.Split(' ')[1]);

//Console.WriteLine($"The Quotient is : {num1/num2} and the remainder is {num1%num2}");

#endregion

#region EvenOdd

//Console.Write("Enter Number : ");
//int checkNum = int.Parse(Console.ReadLine());
//bool check = (checkNum % 2 == 0) ? true : false;
//if(check)
//    Console.WriteLine("Even");
//else
//    Console.WriteLine("Odd");

#endregion

#region maxNumOfThreeNumbers

//Console.Write("Enter the three numbers : ");
//int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//Console.WriteLine("Max Number is : " + numbers.Max());

#endregion

#region grade

//for(int i=0; i<3; i++)
//{
//    Console.Write("Enter char grade : ");
//    char grade = char.Parse(Console.ReadLine());
//    switch (grade)
//    {
//        case 'A':
//            Console.WriteLine("Execllent");
//            break;
//        case 'B':
//            Console.WriteLine("Very Good");
//            break;
//        case 'C':
//            Console.WriteLine("Good");
//            break;
//        case 'D':
//            Console.WriteLine("Fair");
//            break;
//        case 'E':
//            Console.WriteLine("Failed");
//            break;
//        default:
//            Console.WriteLine("Opps Vaild char");
//            break;
//    }
//}

#endregion

#region SumOfNumTo100

//Console.Write("Enter Number : ");
//int num = int.Parse(Console.ReadLine());

//int s = 0;

//for(int i=num; i<= 100; i++)
//{
//    s += i;
//}
//Console.WriteLine($"The sum is : {s}");

#endregion

#region MultiplicationNum

//Console.Write("Enter the number to see it is Multiplication : ");
//int multiNum = int.Parse(Console.ReadLine());

//for(int i=1; i<=10; i++)
//{
//    Console.WriteLine($"{i} * {multiNum} = {i * multiNum}");
//}

#endregion

#region Alphabet

//for(int i=0; i<3; i++)
//{
//    Console.Write("Enter the char : ");
//    char alphChar = char.Parse(Console.ReadLine());
//    if ((int)alphChar >= 65 && (int)alphChar <= 90)
//        Console.WriteLine("Alphabet Char");
//    else if ((int)alphChar >= 97 && (int)alphChar <= 122)
//        Console.WriteLine("Alphabet");
//    else
//        Console.WriteLine("Not Alphabet");
//}

#endregion

#region SentenceWords
//Console.Write("Enter the sentence : ");
//string sentence = Console.ReadLine();
//Console.WriteLine("the number of chars in senetence is : " + sentence.Length);

//string []words = sentence.Split(' ');
//Console.WriteLine("The Length of Words is : " + words.Length);
#endregion