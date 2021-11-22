using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterMode
{
    /// <summary>
    /// adaptee
    /// 原点，宽高组成
    /// </summary>
    class TextView
    {
        public void GetOrigin(out OnePoint x, out OnePoint y)
        {
            x = new OnePoint(3);
            y = new OnePoint(5);
        }

        public void GetExtent(out OnePoint width, out OnePoint height)
        {
            width = new OnePoint(4);
            height = new OnePoint(6);
        }

        public virtual bool IsEmpty()
        {
            return false;
        }
    }

    class OnePoint
    {
        public OnePoint(int value)
        {
            Value = value;
        }
        public int Value { get; set; } 
    }
}
