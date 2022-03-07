using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMode
{
    public class Decorator : VisaulComponent
    {
        private VisaulComponent component;
        public Decorator(VisaulComponent component)
        {
            this.component = component;
        }
        public override void Print()
        {
            component?.Print();
        }
    }
}
