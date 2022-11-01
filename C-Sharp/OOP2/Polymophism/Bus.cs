using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Polymophism
{
    public class Bus : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bus Started");
        }

        public void Start(int speed)
        {
            Console.WriteLine("Bus Started with speed: " + speed);
        }
        public override void Stop()
        {
            Console.WriteLine("Bus Stopped");
        }
    }
}
