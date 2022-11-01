using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Abstraction
{
    public class Teacher : ITeacher
    {
        public string name { get; set; }
        public int Age { get; set; }


        public string GenerateID()
        {
            return " T- " + new Random(DateTime.Now.Second).Next().ToString();
        }

        public string PrepareID()
        {
            return GenerateID();
        }

        public void ProcessID(string ID)
        {
            Console.WriteLine("Teacher Enrollment" + ID);
        }
    }
}
