// See https://aka.ms/new-console-template for more information

int w = int.Parse(Console.ReadLine());

if (w % 2 == 1)
    Console.WriteLine("NO");
else
{
    if (w == 2)
        Console.WriteLine("NO");
    else
    {
        Console.WriteLine("YES");
    }
}