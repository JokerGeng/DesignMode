using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_patterns
{
    public class ImageProxy : Graphics
    {
        Image _image;
        Point _extent;
        string _fileName;

        public ImageProxy(string file)
        {
            _fileName = file;
            _extent = Point.Empty;
            _image = null;
        }

        public void Draw(Point point)
        {
            GetImage().Draw(point);
        }

        public Point GetExtent()
        {
            if(_extent==Point.Empty)
            {
                _extent = GetImage().GetExtent();
            }
            return _extent;
        }

        public void HandleMouse(EventArgs eventArgs)
        {
            
        }

        public void Load(Stream stream)
        {
            
        }

        public void Save(Stream stream)
        {
            
        }

        Image GetImage()
        {
            if(_image==null)
            {
                _image = new Image(_fileName);
            }
            return _image;
        }
    }
}
