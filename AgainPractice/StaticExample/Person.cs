using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public class Person
    {
        public string Name { get; set; }
        public static int Count { get; set; }
        static Person()
        {
            Count = 4;
        }
        public Person()
        {

        }
        public void InCreaseCount()
        {
            Count++;
            //Name = "Rajib";
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
