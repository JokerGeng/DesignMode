using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Patterns
{
    public abstract class CodeGenerator
    {
        public CodeGenerator(ByteCodeStream stream)
        {
            output = stream;
        }
        public ByteCodeStream output;

        public abstract void Visit(StatementNode stream);

        public abstract void Visit(ExpressionNode stream);
    }
}
