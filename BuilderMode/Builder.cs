using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    abstract class Builder
    {
        public abstract void BuildCPU();

        public abstract void BuildMainBoard();

        public abstract Computer GetComputer();
    }
}
