using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Abstraction
{
    public class Teacher : ITeacher
    {
        public string GenerateID()
        {
            return "T-" + new Random(DateTime.Now.Second).Next().ToString();
        }

        public string PreparaeId()
        {
            return GenerateID();
        }

        public void ProcessId(string Id)
        {
            Console.WriteLine("Teacher Enrolled " + Id);
        }
    }
}
