// See https://aka.ms/new-console-template for more information
using Test_Question2;

Console.WriteLine("Hello, World!");

BaseClass obj = new ChildClass(1, "Hassan Tawfik");
Console.WriteLine(obj.GetFirstName());
Console.WriteLine(obj.GetLastName());


try
{
    int n1 = 0;
    int n2 = 10 / n1;
    Console.WriteLine(n2);
}
catch(Exception ex)
{
    throw;
}
Console.WriteLine("4566");