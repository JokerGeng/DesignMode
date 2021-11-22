using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    /// <summary>
    /// Target
    /// 两点定义一个shape
    /// </summary>
    interface IShape
    {
        void BoundingBox(out Point bottomLeft, out Point topRight);

        Manipulator CreateManipulator();
    }
}
