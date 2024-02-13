using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public  class Storage
    {
        private object[] _items;
        private int _counter = 0;
        public Storage(int Count)
        {
            _items = new object[Count];
        }

        public void Add(object item)
        {
            _items[_counter++] = item;
        }

        public object this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }
    }
}
