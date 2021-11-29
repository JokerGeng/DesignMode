using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    class Client
    {
        public void ClientOperate(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Operation());
        }
    }
}
