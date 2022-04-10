using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMode
{
    public class ConcreteClassA : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClassA says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClassA says: Implemented Operation2");
        }
    }
}
