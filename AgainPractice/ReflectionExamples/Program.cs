// See https://aka.ms/new-console-template for more information
using ReflectionExamples;
using System.Reflection;

Console.WriteLine("Hello, World!");


Car car = new Car("Toyata");
car.Start();
car.Stop();



Type t = typeof(Car);
Console.WriteLine(t);
Type t1 = car.GetType();
Console.WriteLine(t1);

ConstructorInfo constructor = t.GetConstructor(new Type[] { typeof(string) });
object item = constructor.Invoke(new object[] { "Nissan" });
MethodInfo method =  t.GetMethod("Start", BindingFlags.Instance | BindingFlags.Public);
MethodInfo method1 =  t.GetMethod("Stop", BindingFlags.Instance | BindingFlags.Public);
method.Invoke(item, new object[] { });
method1.Invoke(item, new object[] { });