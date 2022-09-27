using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Point<T, V> 
        //where T : struct 
        //where V : struct
    {
        public T X { get; set; }
        public V Y { get; set; }
    }
    public class SuperPoint<A, B, C> : Point<A,B>
        //where A : struct
        //where B : struct
    {
        public C Z { get; set; }
    }
    public class Person : IUser
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }
}
