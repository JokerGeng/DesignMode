using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    /// <summary>
    /// 其它adaptee
    /// </summary>
    class TextViewOther : TextView
    {
        public new void GetExtent(out OnePoint width, out OnePoint height)
        {
            width = new OnePoint(7);
            height = new OnePoint(9);
        }

        public new void GetOrigin(out OnePoint x, out OnePoint y)
        {
            x = new OnePoint(8);
            y = new OnePoint(10);
        }
    }
}
