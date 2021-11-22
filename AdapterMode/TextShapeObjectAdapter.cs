using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    /// <summary>
    /// 对象适配器
    /// 可以适配多种adaptee（因为adaptee是其一个成员变量，因此继承此adaptee的都可以作需要适配的接口）
    /// 重定义adaptee的行为比较困难,必须生成adaptee的子类并引用到子类才行
    /// 因此存在多种需要适配的接口
    /// </summary>
    class TextShapeObjectAdapter : IShape
    {
        private TextView TextView { get; set; }
        public TextShapeObjectAdapter(TextView view)
        {
            TextView = view;
        }
        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            OnePoint bottom, left, width, height;
            TextView.GetOrigin(out bottom, out left);
            TextView.GetExtent(out width, out height);
            bottomLeft = new Point(bottom.Value, left.Value);
            topRight = new Point(bottom.Value + height.Value, left.Value + width.Value);
        }

        public Manipulator CreateManipulator()
        {
            throw new NotImplementedException();
        }


        public bool IsEmpty()
        {
            return TextView.IsEmpty();
        }
    }
}
