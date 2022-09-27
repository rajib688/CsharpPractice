//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        private string name;
        public string Name
        {
            get
            {
                if (name == null)
                    return string.Empty;

                return name;
            }
            set
            {
                if (value !=null)
                    name = value;
                else
                    name = string.Empty;
            }
        }
        public string Address { get; set; }
        private readonly int roll;
        public const int ID = 5;
        public Student(int roll, string name)
        {
            this.roll = roll;
            this.name = name;
        }

        public Student()
        {

        }
        ~Student()
        {
            name = null;
        }
        public void Walk()
        {

        }
        public void Walk(int Speed)
        {

        }
        public void Walk(int Speed, int initial)
        {

        }
        //public void setRoll(int roll)
        //{
        //    this.roll = roll;
        //}
    }
} 
