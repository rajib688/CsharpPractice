using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public abstract class Vehicle
    {
        public double Speed { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public int PassengerCount { get; set; }

        public Vehicle()
        {
            Color = "Blue";
        }
        public virtual void Wash()
        {
            Console.WriteLine("Car Washing");
        }

        public abstract void Start();

        public abstract void Stop();

    }
}
