using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Abstraction
{
    public class SuperManTeacher : ITeacher
    {
        public string PrepareID()
        {
            return "Superman";
        }

        public void ProcessID(string ID)
        {
            Console.WriteLine(ID);
        }
    }
}
