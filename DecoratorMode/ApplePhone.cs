using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorMode
{
    public class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("i have a AppPhone");
        }
    }
}
