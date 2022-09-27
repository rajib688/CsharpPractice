using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class FifthGenEngine : TurboEngine
    {
        public FifthGenEngine(double speed) : base(speed)
        {

        }
        public FifthGenEngine():this(0)
        {

        }
        public new void Start()
        {
            Console.WriteLine("FifthGenEngine starting"); ;
        }

        public new void Stop()
        {
            Console.WriteLine("FifthGenEngine stopping"); ;
        }

        public sealed override void IncreaseSpeed(int t)
        {
            
        }
    }
}
