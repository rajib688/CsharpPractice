using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static (string PartA, string PartB) Divide(this string orginal)
        {
            var size = orginal.Length / 2;

            return (orginal.Substring(0, size), orginal.Substring(size + 1));
        }
    }
}
