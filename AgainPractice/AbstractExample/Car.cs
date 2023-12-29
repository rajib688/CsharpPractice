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

        public override void Stop()
        {
            Console.WriteLine("Car Starting");
        }

        public override void Wash()
        {
            base.Wash();
        }
    }
}
