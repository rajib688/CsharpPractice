// See https://aka.ms/new-console-template for more information



using RecodsExamples;

Person person = new Person();
person.name = "Rajib";
person.age = 23;

Person Person1 = person;
if (person== Person1)
{
    Console.WriteLine("Same");
}