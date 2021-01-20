using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Compositor
    {
        protected Compositor()
        {

        }
        public virtual void Compose()
        {

        }

        public virtual void Compose(Component component)
        {

        }
    }
}
