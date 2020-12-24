using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPatterns
{
    public abstract class VisualComponent
    {
        public abstract void Draw();

        public abstract void Resize();
    }
}
