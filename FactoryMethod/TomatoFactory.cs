using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class TomatoFactory : FactoryBase
    {
        public override Food Create()
        {
            return new Tomato();
        }
    }
}
