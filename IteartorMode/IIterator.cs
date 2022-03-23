using System;
using System.Collections.Generic;
using System.Text;

namespace IteartorMode
{
    interface IIterator<T>
    {
        void Reset();

        T Current { get; }

        bool MoveNext();
    }
}
