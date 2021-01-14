using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录
    /// 存储原发器对象的内部需要保存的状态
    /// </summary>
    public class Memento
    {
        public Memento(State state)
        {
            State = state;
        }

        public State State { get; set; }

    }
}
