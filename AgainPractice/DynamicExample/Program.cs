// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");


//dynamic item = new { Name = "Rajib", Age = 41 };
//Console.WriteLine(item.Name);

dynamic item = Getsomthing();
Console.WriteLine(item.Name);

object o = new { Name = "Rajib", Age = 42 };


Type t  = o.GetType();
PropertyInfo p1 = t.GetProperty("Name");
var p2 = p1.GetValue(o);
Console.WriteLine(p2);


object Getsomthing()
{
    return new { Name = "Rajib", Age = 25 };
}