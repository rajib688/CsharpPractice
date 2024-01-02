using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    public struct Student : IPerson
    {
        public string Name { get; set; }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Student()
        {
            id = 0;
            Name = string.Empty;
        }
        public Student(int id)
        {
            this.id = id;
            Name = string.Empty;
        }
        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
