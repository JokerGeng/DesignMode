using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteartorMode
{
    class ConcerteConllection<T> : IListCollection<T>
    {
        public List<T> list = new List<T>();

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }


        public int Length => list.Count;

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public IIterator<T> GetIterator()
        {
            return new ConcerteIterator<T>(this);
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }
    }
}
