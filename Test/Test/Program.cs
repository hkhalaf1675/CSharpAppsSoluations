
//int a = 5;
//int b = 4;
//Console.WriteLine(a.Equals(b));
//Console.WriteLine(a == b);

var numbersList = Enumerable.Range(0, 100).ToList();
var resul = numbersList[^1];// last element
resul = numbersList[^3];

Console.WriteLine(resul);

var resRange = numbersList[..^4];