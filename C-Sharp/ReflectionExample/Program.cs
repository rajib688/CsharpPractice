
// See https://aka.ms/new-console-template for more information


using ReflectionExample;
using System.Reflection;

Car car = new Car("Toyata");
car.Start();
car.Stop();


Type t = typeof(Car);
Type t2 = car.GetType();

ConstructorInfo constructor = t.GetConstructor(new Type[] { typeof(string) });
object item = constructor.Invoke(new object[] { "Rajib" });
MethodInfo method = t.GetMethod("Start", BindingFlags.Instance | BindingFlags.Public);
method.Invoke(item, new object[] { });
MethodInfo method2 = t.GetMethod("Stop", BindingFlags.Instance | BindingFlags.Public);
method2.Invoke(item, new object[] { });