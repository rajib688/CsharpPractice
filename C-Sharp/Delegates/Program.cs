
using Delegates;


int CompareValue(int a, int b)
{
	if (a==b)
		return 0;
	else if (a > b)
		return -1;
	else
		return 1;
}


List<int> ages = new List<int>();
ages.Add(35);
ages.Add(43);
ages.Add(65);
ages.Add(24);
ages.Add(89);

BubbleSort<int> bubbleSort = new BubbleSort<int>(ages);
bubbleSort.Sort(CompareValue);

foreach (var item in ages)
{
	Console.WriteLine(item);
}

//Example 2

int ComparePerson(Person a, Person b)
{
	if (a.Age == b.Age)
	{
		return a.Name.CompareTo(b.Name);
	}
	else if (a.Age > b.Age)
	{
		return 1;
	}
	else
		return -1;
}

List<Person> persons = new List<Person>();
persons.Add(new Person { Name = "Rajib", Age = 23});
persons.Add(new Person { Name = "Rakib", Age = 20 });
persons.Add(new Person { Name = "Liza", Age = 25 });
persons.Add(new Person { Name = "Khadiza", Age = 24 });
persons.Add(new Person { Name = "Morium", Age = 18 });
persons.Add(new Person { Name = "Arif", Age = 18 });

BubbleSort<Person> personSort = new BubbleSort<Person>(persons);
personSort.Sort(ComparePerson);

foreach (var item in persons)
{
	Console.WriteLine($"Name: {item.Name}, Age:{item.Age}");
}