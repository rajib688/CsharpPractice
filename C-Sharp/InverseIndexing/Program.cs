// See https://aka.ms/new-console-template for more information


string[] fruits = new string[] { "apple", "mango", "banana", "jackfruit" };

Console.WriteLine("Normal Arrary");
Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);

Console.WriteLine("\n\n");

Console.WriteLine("InverseIndexing");
Console.WriteLine(fruits[^1]);
Console.WriteLine(fruits[^2]);


Console.WriteLine("-------------------");
for (int i = 1; i <= fruits.Length; i++)
{
    Console.WriteLine(fruits[^i]);
}