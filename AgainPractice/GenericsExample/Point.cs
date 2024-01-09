using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    //public class Point<T, V> where T : class, new()

    public class Point<T, V>
        //where T : struct
        //where V : struct
    {
        public T x { get; set; }
        public V y { get; set; }
    }
    
    public class SuperPoint<A, B, C> : Point<A, B>
        //where A : struct
        //where B : struct
    {
        public C Z { get; set; }
    }

    public class Person : IUser
    {

        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Person()
        {

        }

        public Person(string name) 
        {
            Name = name;
        }

    }

    //public class Point<T>
    //{
    //    public T x { get; set; }
    //    public T y { get; set; }
    //}

}
