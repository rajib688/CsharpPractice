// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



object data = new { Name = "Rajib Rari", Amount = 500 };

dynamic data1 = new { Name = "Rajib Rari", Amount = 500 };
Console.WriteLine(data1.Name);