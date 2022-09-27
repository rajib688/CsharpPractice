using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    public partial class Car
    {
        public void Start()
        {
            Console.WriteLine("Starting");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping");
        }
        public void PrintColor()
        {
            Console.WriteLine(Color);
        }
    }
}
