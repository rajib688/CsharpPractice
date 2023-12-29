using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    public class Student
    {
        private string name;
        public int Roll { get; set; } /*jekono jawga theke use kora jabe seta class ba variable ba Method*/
        public string Name 
        { 
            get
            {
                if (name == null)
                {
                    return string.Empty;    /* Property & AutoProperty*/
                }
                else
                {
                    return name;
                }                
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    name = string.Empty;
                }
            }
        }

        private int Age { get; set; } /* same class a paya jabe*/
        protected int Count; /*clid Class paya jabe */
        internal string Something; /*Same project a paya jabe onno project paya jabe na seta veriable na class*/

        //protected internal Point {get; set;} Veriable use kora jaw na Class a use kora jabe

        public void Walk()
        {

        }
        public void SetRoll(int age)
        {
            this.Age = age;
        }


        //Student Method 2 ta tai akhane method overloading hoice akhane Constructor overloading hoice and paramer different
        public Student()
        {

        }

        public Student(string name, int roll, int age)
        {
            this.Name = name;
            this.Roll = roll;
            this.Age = age;
        }

        //Destructor
        ~Student()
        {

        }
    }
}

//MethodName Always Verb
//ClassName, VeriableName Always Noun