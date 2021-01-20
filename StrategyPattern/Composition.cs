using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Composition
    {
        Compositor _compositor;
        Component _component;
        public Composition(Compositor compositor)
        {
            _compositor = compositor;
        }

        public void Repair()
        {
            _compositor.Compose();
        }

        public void Repair(string placeholder=null)
        {
            _compositor.Compose(_component);
        }

        public void ChnageStrategy(Compositor compositor)
        {
            _compositor = compositor;
        }
    }
}
