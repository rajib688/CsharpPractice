using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Polymophism
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Started");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }
}
