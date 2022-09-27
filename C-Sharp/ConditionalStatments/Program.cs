// See https://aka.ms/new-console-template for more information

int x = 5;

if (x > 5)
{
    Console.WriteLine("X Is smaller than 4");
}
else if (x < 10)
{
    Console.WriteLine("X is Greater than 10");
}
else
{
    Console.WriteLine("X Is equal to 5");
}


string message = x > 5 ? "x is greater than 5" : "x is not greater than 5";

Console.WriteLine(message);