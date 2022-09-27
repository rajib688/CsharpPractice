// See https://aka.ms/new-console-template for more information


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("For");
}

int x = 5;
while (x>0)
{
    Console.WriteLine("While");
    x--;
}
int y = 5;
do
{
    Console.WriteLine("Do while");
    y--;
} while (y>0);

string[] names = new string[] { "Rajib","Rakib","Rasel"};
foreach (var item in names)
{
    Console.WriteLine(item);
}