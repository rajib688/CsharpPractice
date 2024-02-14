// See https://aka.ms/new-console-template for more information
using RecordsExample;

Console.WriteLine("Hello, World!");

Person person = new Person();
person.Name = "Rajib Rari";
person.Age = 24;

                        //2 ta object e same but class ar somoa same hobe na 

Person person1 = new Person();
person1.Name = "Rajib Rari";
person1.Age = 24;


if (person == person1)
{
    Console.WriteLine("Same");
}
