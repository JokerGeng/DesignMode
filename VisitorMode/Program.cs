using System;

namespace VisitorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponentA componentA = new ConcreteComponentA();
            ConcreteComponentB componentB = new ConcreteComponentB();

            IVisitor visitorA = new ConcreteVisitorA();
            IVisitor visitorB = new ConcreteVisitorB();

            componentA.Accept(visitorA);
            componentA.Accept(visitorB);

            componentB.Accept(visitorA);
            componentB.Accept(visitorB);
            Console.Read();
        }
    }
}
