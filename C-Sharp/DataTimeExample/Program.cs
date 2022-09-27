


DateTime DateTime = new DateTime(2022, 01, 22, 10, 26, 40);

var x = DateTime.Now;

var y = DateTime.UtcNow;
Console.WriteLine(x);
Console.WriteLine(y);


DateTime time = DateTime.Parse("16/09/2022");
Console.WriteLine(time.DayOfWeek);