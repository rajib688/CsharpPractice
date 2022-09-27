using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public class Person
    {
        public string name { get; set; }

        public static int Count { get; set; }
        public Person()
        {
            Count = 0;
        }
        public void IncreaseCount()
        {
            Count++;
        }
        public static void Print(string message)
        {
            Console.WriteLine(message + Count);
        }
    }
}
