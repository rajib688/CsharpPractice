using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class Plane : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Plane Starting");
        }

        public override void stop()
        {
            Console.WriteLine("Plane Stopping");
        }
    }
}
