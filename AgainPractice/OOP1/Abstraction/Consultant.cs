using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Abstraction
{
    public class Consultant : ITeacher
    {
        public string GetId()
        {
            return "C-" + DateTime.Now.Ticks.ToString();
        }

        public string PreparaeId()
        {
            return GetId();
        }

        public void ProcessId(string Id)
        {
            Console.WriteLine("Consultant Enrolled "+ Id);
        }
    }
}
