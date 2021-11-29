using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    class ExtendedAbstractioB : Abstraction
    {
        public ExtendedAbstractioB(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstractionB: Extended operation with:\n" +
                base._implementation.ImplementationOperate();
        }
    }
}
