using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMode
{
    public class ConcreteClassB : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClassB says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClassB says: Implemented Operation2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClassB says: Overridden Hook1");
        }
    }
}
