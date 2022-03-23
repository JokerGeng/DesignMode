using System;
using System.Collections.Generic;
using System.Text;

namespace IteartorMode
{
    interface IListCollection<T>
    {
        IIterator<T> GetIterator();

        void Add(T item);

        void Clear();

        bool Remove(T item);

        int Length { get; }

        T this[int index] { get;set; }
    }
}
