using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{

    //public class People : IEnumerable<Person>
    //{
    //    private Person[] _persons;
    //    public People(Person[] persons) 
    //    {
    //        _persons = persons;
    //    }
    //    public IEnumerator<Person> GetEnumerator()
    //    {
    //        return new PeopleEnumerator(_persons);
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}


    public class People : ICollection<Person>
    {

        private Person[] _persons;
        private int _position;
        public People(Person[] persons)
        {
            _persons = persons;
            while (_position < _persons.Length && _persons[_position] != null ) 
            {
                _position++;
            }
        }

        public int Count
        {
            get { return _persons.Length; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public void Add(Person item)
        {
            _persons[_position++] = item;
        }

        public void Clear()
        {
            //_persons = new Person[0];
            _persons = null;
        }

        public bool Contains(Person item)
        {
            for (int i = 0; i < _persons.Length; i++)
            {
                if (item.Equals(_persons[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            for (int i = 0; i < _persons.Length; i++)
            {
                array[arrayIndex++] = _persons[i];
            }
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return new PeopleEnumerator(_persons);
        }

        public bool Remove(Person item)
        {
            Person[] newArray;

            if (Contains(item))
            {
                int counter = 0;
                newArray = new Person[_persons.Length - 1];
                for (int i = 0; i < _persons.Length; i++)
                {
                    if (!_persons[i].Equals(item))
                    {
                        newArray[counter++] = _persons[i];                     
                    }
                }
                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
