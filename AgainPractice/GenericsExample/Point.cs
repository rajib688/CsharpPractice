using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Point<T, V>
    {
        public T x { get; set; }
        public V y { get; set; }
    }
    
    public class SuperPoint<A, B, C> : Point<A, B>
    {
        public C Z { get; set; }
    }


    //public class Point<T>
    //{
    //    public T x { get; set; }
    //    public T y { get; set; }
    //}

}
