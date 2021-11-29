using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeMode
{
    class ExtendedAbstractioA:Abstraction
    {
        public ExtendedAbstractioA(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstractionA: Extended operation with:\n" +
                base._implementation.ImplementationOperate();
        }
    }
}
