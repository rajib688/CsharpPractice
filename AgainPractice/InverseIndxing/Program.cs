// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] fruits = new string[] { "Apple", "Mango", "Banana", "Jackfruit" };

Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);


Console.WriteLine(fruits[^1]);
Console.WriteLine(fruits[^2]);
Console.WriteLine("---------------------------------");
for (int i = 1; i <= fruits.Length; i++)
{
    Console.WriteLine(fruits[^i]);
}