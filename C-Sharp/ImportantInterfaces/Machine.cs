using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class Machine
    {
        public void Operate(ISwitch switchItem)
        {
            switchItem.Open();
        }
    }
}
