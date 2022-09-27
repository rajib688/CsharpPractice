using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    public class Example
    {
        public int sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var n in numbers)
            {
                sum += n;
            }
            return sum;
        }      
        public void test(ref int x)
        {
            Console.WriteLine(x);
            x = 5;
        }
        public void text2(in int x)
        {
            Console.WriteLine(x);
            //x = 5;
        }
        public void text3(out int x)
        {
            x = 5;
            Console.WriteLine(x);
        }
    }
}
