
//int a = 5;
//int b = 4;
//Console.WriteLine(a.Equals(b));
//Console.WriteLine(a == b);

int[] arr = new int[5] { 1, 2, 3, 4, 5 };
var res = arr[..^3];

foreach(int item in res)
    Console.WriteLine(item);    
