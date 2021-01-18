using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserverOne : Observer
    {
        public ConcreteObserverOne(string name) : base(name)
        {

        }
    }

    public class ConcreteObserverTwo : Observer
    {
        public ConcreteObserverTwo(string name):base(name)
        {

        }
    }
}
