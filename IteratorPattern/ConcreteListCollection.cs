using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteListCollection : IListCollection
    {
        public int[] list = new int[5];
        public ConcreteListCollection()
        {
            list[0] = 0;
            list[1] = 1;
            list[2] = 2;
            list[3] = 3;
            list[4] = 4;
        }
        public IIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
