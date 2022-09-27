// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int x = 2 + 3;
Console.WriteLine(x);
x++;
Console.WriteLine(x);
++x;
Console.WriteLine(x);
int y = x++;
//int y = ++x;
Console.WriteLine(y);
Console.WriteLine(x);

x = -5;

bool status  = false;
status = !status;
Console.WriteLine(status);

float a;
double b;
decimal c;

a = 1.82f;

x += 5;

Console.WriteLine(0.1m * 0.5m);

uint m = 0b_1100_1001_0000_0000__0001_0001;

Console.WriteLine($"Before:{Convert.ToString(m, toBase: 2)}");

uint n = m >> 4;

Console.WriteLine($"After:{Convert.ToString(n, toBase: 2)}");


uint n1 = 0b_1001;
Console.WriteLine($"Before: {Convert.ToString(n1, toBase: 2), 4}");
uint n2 = n1 >> 2;
Console.WriteLine($"After: { Convert.ToString(n2, toBase: 2), 4}");



//< > == (<=lessthan) (>=Greaterthan) (!= equalNot) &&(And) ||(Or)

if (x==5)
{
    Console.WriteLine("equal value");
}
else if (x<=3)
{
    Console.WriteLine("5 is greaterthan 3");
}

x = x > 5 ? x++ : x++;

uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint t1 = ~t;
Console.WriteLine(Convert.ToString(t1 ,toBase: 2));



string name = "Dhaka";

string verified = name ?? string.Empty;

Console.WriteLine(verified);


int? test = name ?.Length;