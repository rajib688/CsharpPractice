using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public interface ICar
    {
        void Start();
        void Stop();
    }
    public class BMW : ICar
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Ferarri : ICar
    {
        public void Start()
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
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Common
    {
        public string Name { get; set; }
        public double weight { get; set; }
    }
    public class X985 : Common
    {
        public void Move()
        {

        }
    }
    public class T123 : Common
    {

    }
}
