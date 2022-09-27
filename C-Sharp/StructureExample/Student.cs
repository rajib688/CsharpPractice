using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    public struct Student:IPerson
    {
        public string name { get; set; }

        private int id;
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public Student()
        {
            id = 0;
            name=string.Empty;
        }
        public Student(int id)
        {
            this.id = id;
            name = string.Empty;
        }
        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
