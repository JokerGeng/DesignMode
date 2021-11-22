using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    class PolygonShape : IShape
    {
        public void BoundingBox(out Point bottomLeft, out Point topRight)
        {
            throw new NotImplementedException();
        }

        public Manipulator CreateManipulator()
        {
            throw new NotImplementedException();
        }
    }
}
