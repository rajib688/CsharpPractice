using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Teacher : Person
    {
        public string Address { get; set; }
        public string Salary { get; set; }
        public void SetWeight(double weight)
        {
            Weight = weight;
        }
    }
}
