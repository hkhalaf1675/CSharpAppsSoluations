
#region the diff between String {capital s} and string {small s}
//// string {small s} is alis to String [capital s}
//// there is no differnce between them
//// we can use the two to declare variables
//// or use the static function on class string
//string str1 = "hello from string s small";
//String str2 = "hello from String S capital";

//Console.WriteLine(string.Format("{0} , : {1}", str1, str2));
//Console.WriteLine(String.Format("{0} , : {1}", str1, str2));
#endregion

#region ICPC NewComers Contest1_QD
//string str = Console.ReadLine();

//long num1 = Convert.ToInt64(str.Split(' ')[0]);
//long num2 = Convert.ToInt64(str.Split(' ')[1]);
//long num3 = Convert.ToInt64(str.Split(' ')[2]);
//long result = Convert.ToInt64(str.Split(' ')[3]);

//if (num1 + num2 - num3 == result)
//    Console.WriteLine("YES");
//else if (num1 - num2 + num3 == result)
//    Console.WriteLine("YES");
//else if (num1 + num2 * num3 == result)
//    Console.WriteLine("YES");
//else if (num1 * num2 + num3 == result)
//    Console.WriteLine("YES");
//else if (num1 - num2 * num3 == result)
//    Console.WriteLine("YES");
//else if (num1 * num2 - num3 == result)
//    Console.WriteLine("YES");
//else
//    Console.WriteLine("NO"); 
#endregion

string str = Console.ReadLine();

int num1 = int.Parse(str.Split(' ')[0]);
int num2 = int.Parse(str.Split(' ')[1]);

if (num2 >= num1 && num2 != 0 && num1 % 2 == 1 && num1 % 2 == 0)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");