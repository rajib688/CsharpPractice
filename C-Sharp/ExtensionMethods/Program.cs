// See https://aka.ms/new-console-template for more information

using ExtensionMethods;

Bus bus = new Bus();
bus.Start();
bus.Stop();

string Hello = "Hello world";
(string partA, string partB) parts = Hello.Divide();
Console.WriteLine($"Part A: {parts.partA}, Part B: {parts.partB}");