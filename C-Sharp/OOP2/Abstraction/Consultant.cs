using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Abstraction
{
    public class Consultant : ITeacher
    {
        public string GetID()
        {
            return " C- " + DateTime.Now.Ticks.ToString();
        }

        public string PrepareID()
        {
           return GetID();
        }

        public void ProcessID(string ID)
        {
            Console.WriteLine("Consultant Enrollment" + ID);
        }
    }
}
