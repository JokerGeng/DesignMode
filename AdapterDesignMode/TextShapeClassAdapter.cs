using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignMode
{
    /// <summary>
    /// 类适配器
    /// </summary>
    public class TextShapeClassAdapter : TextView, Shape
    {
        public void BoundingBox(Point bottomLeft, Point topRight)
        {
            GetOrigin();
            GetExtent();
        }

        public Manipulator CreateManipulator()
        {
            return new Manipulator();
        }
        public override bool IsEmpty()
        {
            return base.IsEmpty();
        }
    }
}
