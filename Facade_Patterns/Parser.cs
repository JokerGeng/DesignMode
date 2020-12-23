using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Patterns
{
    public abstract class Parser
    {
        public Parser()
        {

        }

        public abstract void Parse(Scanner scanner, ProgramNodeBuilder builder);
    }
}
