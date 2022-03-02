using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMode
{
    public abstract class Component
    {
        public abstract string Operation();

        public virtual void Add(Component component)
        {

        }

        public virtual void Remove(Component component)
        {

        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
