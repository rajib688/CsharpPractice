// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

DateTime dateTime = new DateTime(2024,6,27,10,40, 10);
Console.WriteLine(dateTime);
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);

/*
string Line = Console.ReadLine();

string[] parts = Line.Split(' ');
int x = int.Parse(parts[0]);
int y = int.Parse(parts[1]);
int z = int.Parse(parts[2]);
*/


DateTime time = DateTime.Parse("2022/06/27");

Console.WriteLine(time.DayOfWeek);