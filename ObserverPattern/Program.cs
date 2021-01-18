using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            Observer one = new ConcreteObserverOne("One");
            Observer two = new ConcreteObserverTwo("Two");

            subject.Attach(one);
            subject.Attach(two);

            subject.Notify();

            Console.Read();
        }
    }
}
