using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_patterns
{
    public class GlyphContent
    {
        public int _index;
        public BTree _fonts;

        public virtual void Next(int step = 1)
        {
            _index += step;
        }

        public virtual void Insert(int quantity = 1)
        {

        }

        public virtual Font GetFont()
        {
            return _fonts.Font;
        }

        public virtual void SetFont(Font font, int span = 1)
        {

        }
    }

}
