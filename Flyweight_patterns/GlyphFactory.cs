using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_patterns
{
    public class GlyphFactory
    {
        const int NCHARCONDES = 128;
        List<Character> characters = new List<Character>();
        public GlyphFactory()
        {
            characters.Capacity = NCHARCONDES;
            for (int i = 0; i < NCHARCONDES; i++)
            {
                characters[i] = new Character('0');
            }
        }

        public virtual Character CreateCharacter(char chr)
        {
            foreach (var item in characters)
            {
                if(item._charcode == chr)
                {
                    return item;
                }
            }
            Character ch = new Character(chr);
            characters.Add(ch);
            return ch;
        }

        public virtual Row CreateRow()
        {
            return new Row();
        }

        public virtual Column CreateColumn()
        {
            return new Column();
        }
    }

    public class Row
    {
    }

    public class Column
    {
    }
}
