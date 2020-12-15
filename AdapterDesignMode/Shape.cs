using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AdapterDesignMode
{
    /// <summary>
    /// Target
    /// </summary>
    public interface Shape
    {
        void BoundingBox(Point bottomLeft, Point topRight);

         Manipulator CreateManipulator();
    }
}
