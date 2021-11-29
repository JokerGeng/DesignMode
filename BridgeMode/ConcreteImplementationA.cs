using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    class ConcreteImplementationA : IImplementation
    {
        public string ImplementationOperate()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
