// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class DelegatesExample
{

    delegate int Compare(int x, int y);

    public static void Main()
    {
        Compare c = Sum;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

public class ActionExample
{
    public void Test(Action<int, int> c, int a, int b)
    {

    }

    public void Something(int a, int b)
    {

    }

    public void Main()
    {
        Test(Something, 5, 7);
    }

}

public class FuncExample
{
    public void Test(Func<int, int, int> c, int a, int b)
    {

    }

    public int Something(int a, int b)
    {
        return a + b;
    }

    public void Main()
    {
        Test(Something, 5, 7);
    }

}
