using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SiChuanFactory : FactoryBase
    {
        public override YaBo CreateYaBo()
        {
            return new SiChuanYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new SichuanYaJia();
        }
    }
}
