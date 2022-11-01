﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public class Storage
    {
        private object[] _items;
        private int counter = 0;

        public Storage(int count)
        {
            _items = new object[count];          
        }
        public void Add(object item)
        {
            _items[counter++] = item;
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
