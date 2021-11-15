using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class FactoryBase
    {
        public abstract YaBo CreateYaBo();

        public abstract YaJia CreateYaJia();
    }
}
