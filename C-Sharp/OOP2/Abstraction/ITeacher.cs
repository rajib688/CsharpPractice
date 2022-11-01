using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Abstraction
{
    public interface ITeacher
    {
        string PrepareID();
        void ProcessID(string ID);
    }
}
