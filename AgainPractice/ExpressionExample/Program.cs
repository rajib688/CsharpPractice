

using System.Linq.Expressions;

public class Program
{
    delegate void test();
    public static void Main(string[] args)
    {
        Expression<Func<int, double, int>> expression = (int a, double b) => a + (int)b;

        Func<int, double, int> m = expression.Compile();

        Console.WriteLine(m(2,2.5));
    }
}
