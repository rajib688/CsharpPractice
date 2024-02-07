using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
                    //Dependency Inversion Principle
    public class Car    /*akhane Engine hoice car dependency*/
    {
        //private Engine engine { get; set; }
        private IEngine engine { get; set; }

        public Car(IEngine engine) 
        {
            this.engine = engine;
        }

        public void Start()
        {
            engine.Start();
        }

    }

    public interface IEngine
    { 
        void Start();
    }

    public class Engine : IEngine
    { 
        public void Ignite() 
        { 

        }

        public void Start()
        {
            Ignite();
        }
    }

    public class TurboEngine : IEngine
    {
        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
