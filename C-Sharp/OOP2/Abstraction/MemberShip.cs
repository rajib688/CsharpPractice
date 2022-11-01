using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Abstraction
{
    public class MemberShip
    {
        public void EnrolTeacher(ITeacher teacher)
        {
            string ID = teacher.PrepareID();

            teacher.ProcessID(ID);
        }
    }
}