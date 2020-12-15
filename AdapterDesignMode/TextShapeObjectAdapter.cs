using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignMode
{
    /// <summary>
    /// 对象适配器
    /// </summary>
    class TextShapeObjectAdapter : Shape
    {
        TextView View { get; set; }
        public TextShapeObjectAdapter(TextView textView)
        {
            View = textView;
        }

        public bool IsEmpty()
        {
            return View.IsEmpty();
        }

        public void BoundingBox(Point bottomLeft, Point topRight)
        {
            View.GetOrigin();
            View.GetExtent();
        }

        public Manipulator CreateManipulator()
        {
            return new Manipulator();
        }
    }
}
