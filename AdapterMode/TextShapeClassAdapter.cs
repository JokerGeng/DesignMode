using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    /// <summary>
    /// 类适配器
    /// 可以重定义adaptee的行为,
    /// 但不能适配多种adaptee,
    /// 因此存在多种适配器
    /// </summary>
    class TextShapeClassAdapter : TextView, IShape
    {
        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            OnePoint bottom, left, width, height;
            GetOrigin(out bottom, out left);
            GetExtent(out width, out height);
            bottomLeft = new Point(bottom.Value, left.Value);
            topRight = new Point(bottom.Value + height.Value, left.Value + width.Value);
        }

        public Manipulator CreateManipulator()
        {
            throw new NotImplementedException();
        }

        public override bool IsEmpty()
        {
            return base.IsEmpty();
        }
    }

    /// <summary>
    /// 重定义adaptee的行为
    /// </summary>
    class TextShapeClassAdapterOther : TextView, IShape
    {
        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            OnePoint bottom, left, width, height;
            GetOrigin(out bottom, out left);
            GetExtent(out width, out height);
            bottomLeft = new Point(bottom.Value, left.Value);
            topRight = new Point(bottom.Value + height.Value, left.Value + width.Value);
        }

        public new void GetExtent(out OnePoint width, out OnePoint height)
        {
            width = new OnePoint(11);
            height = new OnePoint(12);
        }

        public new void GetOrigin(out OnePoint x, out OnePoint y)
        {
            x = new OnePoint(10);
            y = new OnePoint(10);
        }

        public Manipulator CreateManipulator()
        {
            throw new NotImplementedException();
        }

        public override bool IsEmpty()
        {
            return base.IsEmpty();
        }
    }
}
