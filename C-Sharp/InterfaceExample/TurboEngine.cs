using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class TurboEngine : IEngine
    {
        public string Model { get; set ; }

        private double _speed;
        public TurboEngine(double speed)
        {
            _speed = speed;
        }
        public void Start()
        {
            Console.WriteLine("Turbo engine starting"); ;
        }

        public void Stop()
        {
            Console.WriteLine("Turbo engine stopping"); ;
        }

        public virtual void IncreaseSpeed(int t)
        {

        }


        //public double GetSpeed()
        //{
        //    return _speed;
        //}
    }
}
