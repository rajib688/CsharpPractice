// See https://aka.ms/new-console-template for more information

using System.Reflection;



dynamic item = GetSomething();
Console.WriteLine(item.Name);



object GetSomething()
{
    return new { Name = "Rajib", Age = 41 };
}

object o = new { Name= "Rari", Age = 25 };
Type t=o.GetType();
PropertyInfo p1 = t.GetProperty("Name");
var sm = p1.GetValue(o);
Console.WriteLine(sm);
