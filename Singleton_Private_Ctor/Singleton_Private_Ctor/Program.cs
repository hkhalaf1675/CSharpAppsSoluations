// See https://aka.ms/new-console-template for more information
using Singleton_Private_Ctor;

Console.WriteLine("Hello, World!");

Singleton obj1 = Singleton.CreateObject(1, "Hassan");

Console.WriteLine(obj1.GetHashCode());

Singleton obj2 = Singleton.CreateObject(2, "Hassan");

Console.WriteLine("----");

Console.WriteLine(obj2.GetHashCode());

