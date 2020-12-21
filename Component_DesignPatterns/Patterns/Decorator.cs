using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_DesignPatterns
{
    public abstract class Decorator:VisualComponent
    {
        private VisualComponent Component;
        public Decorator(VisualComponent component)
        {
            Component = component;
        }

        public override void Draw()
        {
            Component.Draw();
        }

        public override void Resize()
        {
            Component.Resize();
        }
    }
}
