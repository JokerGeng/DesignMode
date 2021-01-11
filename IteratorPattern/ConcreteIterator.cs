using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteIterator : IIterator
    {
        ConcreteListCollection list;
        int index = -1;
        public ConcreteIterator(ConcreteListCollection collection)
        {
            list = collection;
        }

        public object Current
        {
            get
            {
                if(index<list.list.Length)
                {
                    return list.list[index];
                }
                return null;
            }
        }

        public bool MoveNext()
        {
            if (index !=list.list.Length)
            {
                index++;
            }
            return index < list.list.Length;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
