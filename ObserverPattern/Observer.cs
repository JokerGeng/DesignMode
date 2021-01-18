using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {
        string Name { get; set; }
        void Updata(Subject subject);
    }
    public abstract class Observer
    {
        public Observer(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public virtual void Updata(Subject subject)
        {
            Console.WriteLine($"{Name} received updata");
        }
    }
}
