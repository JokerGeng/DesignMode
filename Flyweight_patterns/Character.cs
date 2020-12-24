using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_patterns
{
    public class Character : Glyph
    {
        public Character(char code)
        {
            _charcode = code;
        }
        public virtual void Draw(Window window, GlyphContent content)
        {

        }

        public override void Draw(Window window)
        {
            throw new NotImplementedException();
        }

        public override void SetFont(Font font, GlyphContent content)
        {
            throw new NotImplementedException();
        }

        public override Font GetFont(GlyphContent content)
        {
            throw new NotImplementedException();
        }

        public override void First(GlyphContent content)
        {
            throw new NotImplementedException();
        }

        public override void Next(GlyphContent content)
        {
            throw new NotImplementedException();
        }

        public override bool IsDone(GlyphContent content)
        {
            throw new NotImplementedException();
        }

        public override Glyph Current(GlyphContent content)
        {
            throw new NotImplementedException();
        }

        public override void Insert(Glyph glyph, GlyphContent content)
        {
            throw new NotImplementedException();
        }

        public override void Remove(GlyphContent content)
        {
            throw new NotImplementedException();
        }

        public char _charcode;
    }
}
