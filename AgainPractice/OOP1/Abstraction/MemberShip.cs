using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Abstraction
{
    public class MemberShip
    {
        public void EnrolTeacher(ITeacher teacher)
        {
            string Id = teacher.PreparaeId();

            teacher.ProcessId(Id);



            //if (Id.StartsWith("T-"))
            //{
            //    Console.WriteLine("Teacher Enrolled");
            //}
            //else if (Id.StartsWith("C-"))
            //{
            //    Console.WriteLine("Consultant Enrolled");
            //}

            //more codes here
        }
    }
}
