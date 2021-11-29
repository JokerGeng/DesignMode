using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    class ConcreteImplementationB : IImplementation
    {
        public string ImplementationOperate()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }
}
