using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorMode
{
    public class ConcreteVisitorB : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.Write("ConcreteVisitorB ");
            Console.WriteLine(element.SpecialMethodOfConcreteComponentA());
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.Write("ConcreteVisitorB ");
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB());
        }

    }
}
