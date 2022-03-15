using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyMode
{
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
