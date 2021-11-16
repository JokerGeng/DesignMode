using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    //导演类的作用是规定创建产品类的流程/装配过程
    class OtherDirector
    {
        public void CreatComputer(Builder builder)
        {
            builder.BuildMainBoard();
            builder.BuildCPU();
        }
    }
}
