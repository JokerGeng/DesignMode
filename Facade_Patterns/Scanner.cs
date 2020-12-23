using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Patterns
{
    public abstract class Scanner
    {
        IStream inputStream;
        public Scanner(IStream stream)
        {
            inputStream = stream;
        }

        public abstract Token Scan();

    }
}
