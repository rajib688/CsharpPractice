using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public interface ICar   /*Open Closed Desgin principle*/
    { 
        void Star();
        void Stop();
    }
    public class BMW : ICar
    {
        public void Star()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Ferari : ICar
    {
        public void Star()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Toyota : ICar
    {
        public void Star()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }


        //Liskov Substitution Principle

        public  class Common
        {
            public  string Name { get; set; }
            public  double weight { get; set; }
        }

        public class X905 : Common
        {          
            public void Move()
            {

            }
        }

        public class T123 : Common
        {

        }
    }
}
