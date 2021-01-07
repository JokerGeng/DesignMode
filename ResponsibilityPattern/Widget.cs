using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityPattern
{
    public class Widget : HelpHandler
    {
        Widget _parent;
        public Widget(Widget w, int t = -1) : base(w, t)
        {
            _parent = w;
        }
    }
}
