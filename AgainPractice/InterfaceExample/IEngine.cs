using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IEngine
    {
        string Model { get; set; }
        void Start();
        void Stop();

        public double GetSpeed()
        {
            return 0;
        }

    }
}
