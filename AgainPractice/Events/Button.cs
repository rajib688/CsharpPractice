using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Button
    {
        public delegate void PrintMessage(string message);
        public event PrintMessage OnClick;

        public void Click()
        {
            if (OnClick!=null)
            {
                OnClick.Invoke($"Button was clicked at : { DateTime.Now}");
            }
        }
    }
}