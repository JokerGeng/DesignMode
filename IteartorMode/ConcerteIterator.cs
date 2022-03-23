using System;
using System.Collections.Generic;
using System.Text;

namespace IteartorMode
{
    class ConcerteIterator<T> : IIterator<T>
    {
        IListCollection<T> list;
        int index = -1;
        public ConcerteIterator(IListCollection<T> collection)
        {
            list = collection;
        }
        public T Current
        {
            get
            {
                if (index < list.Length)
                {
                    return list[index];
                }
                return default;
            }
        }

        public bool MoveNext()
        {
            if (index != list.Length)
            {
                index++;
            }
            return index < list.Length;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
