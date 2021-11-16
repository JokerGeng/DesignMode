using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    //抽象创建产品需要的各个部件
    abstract class Builder
    {
        public abstract void BuildCPU();

        public abstract void BuildMainBoard();

        public abstract Computer GetComputer();
    }
}
