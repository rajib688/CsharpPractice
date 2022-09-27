


using GenericsExample;
using System.Collections;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

Point<int, double> point = new Point<int, double>();
point.X = 1;
point.Y = 1.5;

Point<int, int> point1 = new Point<int, int>();

Point<double, int> point2 = new Point<double, int>();

SuperPoint<int, string, Char> superpoint = new SuperPoint<int, string, Char>();
superpoint.X = 5;
superpoint.Y = "Dhaka";

Point<Person, double> point3 = new Point<Person, double>();

SecuritySystem<Person> securitySystem = new SecuritySystem<Person>();
securitySystem.Open<string>("Rajib");
int x = default(int);

List<int> list = new List<int>();
list.Add(2);
list.Add(3);

Dictionary<string, int> scores = new Dictionary<string, int>();
scores.Add("Rajib", 200);
scores["Rajib"]= 100;

HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(1);
Console.WriteLine(set.Count);

LinkedList<int> list1 = new LinkedList<int>();
list1.AddLast(1);
list1.AddLast(2);
LinkedListNode<int> node = list1.Find(1);
list1.AddAfter(node, 5);

PriorityQueue<int, double> priorityQueue = new PriorityQueue<int, double>();
priorityQueue.Enqueue(5, 2);
priorityQueue.Enqueue(15, 1);

int item = priorityQueue.Dequeue();
Console.WriteLine(item);

Queue<int> queue = new Queue<int>();
queue.Enqueue(5);
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
    Console.WriteLine(a.Value);

SortedDictionary<string, int> sorteddict = new SortedDictionary<string, int>();
sorteddict.Add("B", 34);
sorteddict.Add("C", 56);


SortedSet<string> sortset = new SortedSet<string>();
sortset.Add("Mango");
sortset.Add("Orange");
sortset.Add("Banana");
foreach (var b in sortset)
    Console.WriteLine(b);


ArrayList arraylist = new ArrayList();
arraylist.Add(2);
arraylist.Add("Dhaka");


int[] myInts = new int[5] { 6, 7, 8, 9, 10 };
BitArray myBas = new BitArray(myInts);
foreach (var m in myBas)
    Console.WriteLine(m);

Hashtable openwith = new Hashtable();
openwith.Add("txt", "Notepad exe");

Queue myQ = new Queue();
myQ.Enqueue("Hello");

SortedList mySL = new SortedList();
mySL.Add("Third", "!");

Stack myStack = new Stack();
myStack.Push("Hello");




