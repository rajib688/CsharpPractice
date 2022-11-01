using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class BusExtensions
    {
        public static void Stop(this Bus bus)
        {
            Console.WriteLine("Bus Stopping");
        }
    }
}
