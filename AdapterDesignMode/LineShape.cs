using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignMode
{
    public class LineShape : Shape
    {
        public void BoundingBox(Point bottomLeft, Point topRight)
        {
           
        }

        public Manipulator CreateManipulator()
        {
            return new Manipulator();
        }
    }
}
