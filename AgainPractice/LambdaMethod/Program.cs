// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");

int Sum(int a, int b)
{
    return a + b;
}
                      /*Lambdamethod*/
int Sum1(int a, int b) =>  a + b;  

Console.WriteLine(Sum1(5, 45));


void Print(string m) => Console.WriteLine(m);


Func<double, double, double> n = (a, b) => a + b;
Console.WriteLine(n(2, 2));