using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverMode
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
