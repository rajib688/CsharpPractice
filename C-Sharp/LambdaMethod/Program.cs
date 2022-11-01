
//Normal

/*
int Sum(int a, int b)
{
    return a + b;
}

void Print(string m)
{
    Console.WriteLine(m);
}
*/

//LambdaMethod

int Sum(int a, int b) => a + b;

void Print(string m) => Console.WriteLine(m);


//AnonomachMethod

Func<double, double, double> m = (a, b) => a + b;

Console.WriteLine(m(2, 2));


//int MyMethod(double a, string b)
//{
//    return 0;
//}