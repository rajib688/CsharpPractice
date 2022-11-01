using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class BubbleSort<T>
    {
        private IList<T> _items;
        public delegate int Compare(T x, T y);
        public BubbleSort(IList<T> items)
        {
            _items = items;
        }
        public void Sort(Compare compare)
        {
            T temp;
            for (int j = 0; j <= _items.Count - 2; j++)
            {
                for (int i = 0; i <= _items.Count - 2; i++)
                {
                    if (compare(_items[i] , _items[i + 1]) > 0)
                    {
                        temp = _items[i + 1];
                        _items[i + 1] = _items[i];
                        _items[i] = temp;
                    }
                }
            }
        }
    }
}
