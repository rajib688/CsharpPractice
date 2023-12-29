using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        public string Name { get; set; }
        protected double Weight { get; set; }
        public double Height { get; set; }

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
