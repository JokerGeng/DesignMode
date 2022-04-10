using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorMode
{
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);

        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}
