// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



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