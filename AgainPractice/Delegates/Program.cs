// See https://aka.ms/new-console-template for more information
using Delegates;

Console.WriteLine("Hello, World!");


var x = 5;
var y = 6;

var r = sum(x, y);
 
int sum(int x, int y)
{
    return x + y;
}


//delegate int Calculate(int x, int y);



List<int> ages = new List<int>();

ages.Add(21);
ages.Add(12);
ages.Add(2);
ages.Add(10);
ages.Add(15);

BubbleSort bubbleSort = new BubbleSort(ages);
bubbleSort.Sort(CompareValue);

int CompareValue(int a, int b)
{
    if (a == b)
        return 0;
    else if (a < b)
        return -1;
    else
        return 1;
}

foreach (var item in ages)
{
    Console.WriteLine(item);
}


//Example 2


int ComparePerson(Person a, Person b)
{
    if(a.Age == b.Age)
    {
        return a.Name.CompareTo(b.Name);
    }
    else if (a.Age > b.Age)
    {
        return 1;
    }
    else
    {
        return -1;
    }
}
List<Person> person = new List<Person>();

person.Add(new Person { Name = "Rajib", Age = 24 });
person.Add(new Person { Name = "Tania", Age = 20 });
person.Add(new Person { Name = "Anoar", Age = 15 });
person.Add(new Person { Name = "Moriun", Age = 20 });

BubbleSort<Person> personSort = new BubbleSort<Person>(person);
personSort.Sort(ComparePerson);

foreach (var item in person)
{
    Console.WriteLine($"Name : { item.Name}, Age : {item.Age}");
}