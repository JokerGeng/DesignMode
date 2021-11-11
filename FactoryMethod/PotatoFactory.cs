using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class PotatoFactory : FactoryBase
    {
        public override Food Create()
        {
            return new Potato();
        }
    }
}
