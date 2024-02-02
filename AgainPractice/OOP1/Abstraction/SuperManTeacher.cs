using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Abstraction
{
    public class SuperManTeacher : ITeacher
    {
        public string PreparaeId()
        {
            return "Super Man";
        }

        public void ProcessId(string Id)
        {
            Console.WriteLine(Id);
        }
    }
}
