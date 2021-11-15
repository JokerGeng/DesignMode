using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    class Director
    {
        public Computer CreatComputer(Builder builder)
        {
            builder.BuildCPU();
            builder.BuildMainBoard();
            return builder.GetComputer();
        }
    }
}
