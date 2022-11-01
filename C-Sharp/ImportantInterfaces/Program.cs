// See https://aka.ms/new-console-template for more information


using ImportantInterfaces;

//Console.WriteLine("Hello, World!");

//Machine machine = new Machine();

//PanelSwitch panelSwitch = new PanelSwitch();

//Switch Switch = new Switch();

//machine.Operate(panelSwitch);



Person[] persons = new Person[3];
persons[0] = new Person { Name = "Rajib", Age = 12 };
persons[1] = new Person { Name = "Rakib", Age = 12 };

People people = new People(persons);
people.Add(new Person { Name = "Rasedul", Age = 22 });

foreach (var p in people)
{
    Console.WriteLine(p.Name);
}

using Downloader downloader = new Downloader();
downloader.Download("https://www.google.com");

using (Downloader downloader2 = new Downloader())
{
    downloader2.Download("https://www.google.com");
}

Person persons3 = new Person();
Person person4 = (Person)persons3.Clone();
