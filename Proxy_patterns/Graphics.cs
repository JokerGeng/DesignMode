using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_patterns
{
    public interface Graphics
    {
        void Draw(Point point);
        void HandleMouse(EventArgs eventArgs);

        Point GetExtent();

        void Load(Stream stream);

        void Save(Stream stream);
    }
}
