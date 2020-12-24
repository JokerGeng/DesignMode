using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_patterns
{
    public abstract class Glyph
    {
        public abstract void Draw(Window window);

        public abstract void SetFont(Font font, GlyphContent content);

        public abstract Font GetFont(GlyphContent content);

        public abstract void First(GlyphContent content);

        public abstract void Next(GlyphContent content);

        public abstract bool IsDone(GlyphContent content);

        public abstract Glyph Current(GlyphContent content);

        public abstract void Insert(Glyph glyph, GlyphContent content);

        public abstract void Remove(GlyphContent content);
    }
}
