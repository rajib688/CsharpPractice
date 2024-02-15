// See https://aka.ms/new-console-template for more information
using Threading;

Console.WriteLine("Hello, World!");


/*
Thread thread = new Thread(()=> PrintEventNumbers());
thread.Start();

Thread thread1 = new Thread(()=> PrintOldNumbers());
thread1.Start();

Console.ReadLine();
void PrintEventNumbers()
{
    for (int i = 0; i < 100; i += 2)
    {
        Console.WriteLine(i);
    }
}

void PrintOldNumbers()
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

Task<int> t = processing.Sum(2, 4);
Task<int> t1 = processing.Sum(2, 46);

Task<int>[] tasks = new Task<int>[4];
tasks[0] = t;
tasks[1] = t1;

await Task.WhenAll(tasks);