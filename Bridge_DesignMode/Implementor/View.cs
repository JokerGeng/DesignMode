using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignMode
{
    public abstract class View
    {
        public abstract void GetOrigin();

        public abstract void GetExtent();

        public abstract void DrawOn();
    }
}
