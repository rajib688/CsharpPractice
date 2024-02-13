// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] ages = new int[] { 5, 9, 3, 23, 40 };

//select * from Ages where age<10

var v = from age  in ages where  age < 10 select age;


IEnumerable<int> v1 = from age  in ages where  age < 10 select age;

List<int> v2 = (from age  in ages where  age < 10 select age).ToList();

int[] v3 = (from age in ages where age < 10 select age).ToArray();

int[] v4 = ages.Where(x => x < 10).ToArray();