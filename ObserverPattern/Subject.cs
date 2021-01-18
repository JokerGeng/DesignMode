using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subject
    {
        private List<Observer> _observers;

        public Subject()
        {
            _observers = new List<Observer>();
        }
        public virtual void Attach(Observer observer)
        {
            if(!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public virtual void Detach(Observer observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public virtual void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Updata(this);
            }
        }
    }
}
