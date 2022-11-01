
// See https://aka.ms/new-console-template for more information
using Threading;


/*
int x = 5;
x = Sum(x, 3);

Console.WriteLine(x);

int Sum(int x, int y)
{
    return x + y;
}

*/

/*
Thread thread = new Thread(() => PrintEvenNumbers());
thread.Start();

Thread thread1 = new Thread(() => PrintOddNumber());
thread1.Start();

Console.ReadLine();

void PrintEvenNumbers()
{
    for (int i = 0; i < 100; i += 2)
    {
        Console.WriteLine(i);
    }
}

void PrintOddNumber()
{
    for (int i = 1; i < 100; i += 2)
    {
        Console.WriteLine(i);
    }
}

*/


Processing processing = new Processing();
int r = await processing.Sum(2, 2);
Console.WriteLine(r);
Console.ReadLine();


Task<int> t = processing.Sum(2, 2);
Task<int> t1 = processing.Sum(2, 4);
Task<int> t2 = processing.Sum(2, 6);
Task<int> t3 = processing.Sum(2, 8);

Task<int>[] tasks = new Task<int>[4];
tasks[0] = t;
tasks[1] = t1;
tasks[2] = t2;
tasks[3] = t3;

await Task.WhenAll(tasks);