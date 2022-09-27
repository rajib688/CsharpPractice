using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class PanelSwitch :Panel, ISwitch
    {
        public void Open()
        {
            Console.WriteLine("Opening");
        }
    }
}
