// See https://aka.ms/new-console-template for more information

using ImportantInterface;

Console.WriteLine("Hello, World!");

/*
Machine machine = new Machine();
PanelSwitch panelSwitch = new PanelSwitch();
machine.Operate(panelSwitch);

Switch s = new Switch();
machine.Operate(panelSwitch);
*/

/*
People people = new People(new Person[] 
{

new Person { Name = "Rajib Rari", Age = 12 }, 
new Person { Name = "Rajib Hossen", Age = 24 } 

});

foreach (var item in people)
{
    Console.WriteLine($"Name : {item.Name}, Age : {item.Age}");
}
*/

/*
Person[] persons = new Person[3];
persons[0] = new Person { Name = "Rajib Rari", Age = 12 };
persons[1] = new Person { Name = "Rajib Hossen", Age = 24 };

People people = new People(persons);
people.Add(new Person { Name = "Rakib", Age = 25 });
foreach (var item in people)
{
    Console.WriteLine($"Name : {item.Name}, Age : {item.Age}");
}
*/

using Downloader downloader = new Downloader();
downloader.Download("https://www.google.com");
//downloader.Dispose();


Person person = new Person();
Person person1 = (Person)person.Clone();
Person person2 = person.Copy();
