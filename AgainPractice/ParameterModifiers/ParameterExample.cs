using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    public class ParameterExample
    {

        //public int sum(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //Or Parameter Modification

        public int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(var n in numbers)
                sum += n;
            return sum;
        }

        public void Test(ref int x)
        {
            x = 5;
        }
        public void Test2(in int x)
        {
            Console.WriteLine(x); /*akhane initial kora jabe na */
            //x = 5; error
        }
        public void Test3(out int x)
        {
            x = 5; /*akhane initial kora jabe lagbe nale error */
            Console.WriteLine(x);
        }
    }
}
