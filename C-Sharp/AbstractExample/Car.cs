using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Starting");
        }

        public override void stop()
        {
            Console.WriteLine("Car Stoping");
        }

        public override void Wash()
        {
            Console.WriteLine("Car washing");
        }
    }
}
