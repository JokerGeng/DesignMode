using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorMode
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
