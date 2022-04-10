using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorMode
{
    public class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        public string SpecialMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}
