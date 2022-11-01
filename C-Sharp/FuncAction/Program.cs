//// See https://aka.ms/new-console-template for more information


public class Program
{
    //Example first
/*
    delegate int Compare(int x, int y);
    public static void Main()
    {
        Compare c = Sum;

    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    */

    ///2nd Example
    public static void test(Func<int , int, int > c, int a, int b)
    {

    }

    public static int Something(int a, int b)
    {
        return a + b;
    }

    public static void Main()
    {
        test(Something, 5, 7);
    }
}

