using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorMode
{
    public class ConcreteVisitorA : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.Write("ConcreteVisitorA ");
            Console.WriteLine(element.SpecialMethodOfConcreteComponentA());
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.Write("ConcreteVisitorA ");
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB());
        }
    }
}
