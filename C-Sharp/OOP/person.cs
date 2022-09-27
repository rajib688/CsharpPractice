using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class person
    {
        public string Name { get; set; }
        protected double height { get; set; }
        public double weight { get; set; }

        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
