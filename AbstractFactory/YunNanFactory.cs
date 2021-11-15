using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class YunNanFactory : FactoryBase
    {
        public override YaBo CreateYaBo()
        {
            return new YunNanYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new YunNanYaJia();
        }
    }
}
