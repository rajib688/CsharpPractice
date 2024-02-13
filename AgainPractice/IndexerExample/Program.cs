// See https://aka.ms/new-console-template for more information
using IndexerExample;

Console.WriteLine("Hello, World!");


int[] ages = new int[10];


List<int> list = new List<int>();
list.Add(1);
list[0] = 2;

Storage storage = new Storage(5);
storage.Add(3);
storage.Add(4);
storage.Add(5);
storage[1] = 9;
Console.WriteLine(storage[1]);