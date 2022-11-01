
using System.Linq.Expressions;

public class Program
{

    public static void Main(string[] args)
    {
        Expression<Func<int, Double, int>> expression = (int a, double b) => a + (int)b;
        Func<int, double, int> m= expression.Compile();
        Console.WriteLine(m(2, 2.5));
    }
}



