// See https://aka.ms/new-console-template for more information

using GenericsExample;
using System.Collections;

Console.WriteLine("Hello, World!");
/*
Point<int, double> point = new Point<int, double>();
Point<int, int> point1 = new Point<int, int>();
Point<double, int> point2 = new Point<double, int>();


point.x = 1;
point.y = 2.5;
*/

SuperPoint<int, string, double> superPoint = new SuperPoint<int, string, double>();
superPoint.x = 5;
superPoint.y = "Rajib Rari";
superPoint.Z = 10.5;


Point<Person, double> point3 = new Point<Person, double>();


SecuritySystem<Person> securitySystem = new SecuritySystem<Person>();
securitySystem.Open<string>("Rajib Rari");
int x = default(int);


List<int> list = new List<int>();
list.Add(2);
list.Add(3);
list.Add(4);
list[0] = 5;
Dictionary<string, int> scores = new Dictionary<string, int>();
scores.Add("Jalal Uddin", 200);
scores["Rajib Rari"] = 100;

HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Count();

LinkedList<int> list2 = new LinkedList<int>();
list2.AddFirst(1);
list2.AddLast(2);
LinkedListNode<int> node = list2.Find(1);
list2.AddAfter(node, 3);


PriorityQueue<int, double> priorityQueue = new PriorityQueue<int, double>();
priorityQueue.Enqueue(5, 2);
priorityQueue.Enqueue(15, 2);

int item = priorityQueue.Dequeue();
Console.WriteLine(item);


Queue<int> queue = new Queue<int>();
queue.Enqueue(3);
queue.Enqueue(15);
Console.WriteLine(queue.Dequeue());

Stack<int> stack = new Stack<int>();
stack.Push(5);
stack.Push(15);
Console.WriteLine(stack.Pop());

SortedList<string, int> sortedlist = new SortedList<string, int>();
sortedlist.Add("D", 12);
sortedlist.Add("B", 15);
foreach (var a in sortedlist)
{
    Console.WriteLine(a.Value);
}


SortedDictionary<string, int> sortDictionary = new SortedDictionary<string, int>();
sortDictionary.Add("B", 34);
sortDictionary.Add("D", 33);


SortedSet<string> sortset = new SortedSet<string>();
sortset.Add("Mango");
sortset.Add("Mango");
sortset.Add("Orange");
foreach (var t in sortset)
{
    Console.WriteLine(t);
}

//No-Generics

ArrayList arrayList = new ArrayList();
arrayList.Add(2);
arrayList.Add("Dhaka");

int[] myInts = new int[5] { 6, 7, 8, 9, 10 };
BitArray myBAS = new BitArray(myInts);
foreach (var m in myBAS)
{
    Console.WriteLine(m);
}

Hashtable hashtable = new Hashtable();
hashtable.Add("txt", "Notepad.exe");

Queue queue1 = new Queue();
queue1.Enqueue("Hello");


SortedList mysl = new SortedList();
mysl.Add("Third", "!");


Stack stack1 = new Stack();
stack1.Push("Hello");