using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class Machine
    {
        public void Operate(ISwitch switchItem)
        {
            switchItem.Open();
        }
    }
}
