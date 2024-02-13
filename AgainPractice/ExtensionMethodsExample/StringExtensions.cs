using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExample
{
    public static class StringExtensions
    {
        public static (string PartA, string PartB) Divide (this string Original)
        {
            var size = Original.Length/2;
            return (Original.Substring(0, size), Original.Substring(size + 1));
        }
    }
}
