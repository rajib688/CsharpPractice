// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string Path = "H:\\GitHub\\CsharpPractice\\Demo.txt";
var content = "Hello from C#";
File.WriteAllText(Path, content );


/*
using FileStream fileStream =  File.Create(Path);
fileStream.WriteByte();
*/