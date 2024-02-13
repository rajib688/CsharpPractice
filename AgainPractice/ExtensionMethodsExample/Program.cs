// See https://aka.ms/new-console-template for more information
using ExtensionMethodsExample;

Console.WriteLine("Hello, World!");



Bus bus = new Bus();
bus.Start();
bus.Stop();

string Hello = "Hello worldm";
(string PartA, string PartB) part = Hello.Divide();
Console.WriteLine($"Part A: {part.PartA}, Part B : {part.PartB}");