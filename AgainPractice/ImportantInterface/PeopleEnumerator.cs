using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class PeopleEnumerator : IEnumerator<Person>
    {
        private Person[] _persons;
        private int _currentIndex;
        public PeopleEnumerator(Person[] person)
        {
            _persons = person;
            _currentIndex = -1;
        }
        public Person Current
        {
            get
            {
                return _persons[_currentIndex];
            }
        }
        object IEnumerator.Current 
        {
            get 
            { 
                return Current;
            } 
        }

        public void Dispose()
        {
            _currentIndex = -1;
            _persons = null;
        }

        public bool MoveNext()
        {
            _currentIndex++;
            if (_currentIndex >= _persons.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
