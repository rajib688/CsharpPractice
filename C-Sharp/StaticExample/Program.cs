// See https://aka.ms/new-console-template for more information

using StaticExample;

Person p1 = new Person();
p1.name = "Rajib";
p1.IncreaseCount();
Person p2 = new Person();
p2.name = "Rakib";
p2.IncreaseCount();


Console.WriteLine(Person.Count);

Person.Print("Hello World");
