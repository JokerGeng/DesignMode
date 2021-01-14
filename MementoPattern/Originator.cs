using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 原发器
    /// 创建一个备忘录，用于记录当前时刻的内部状态
    /// </summary>
    public class Originator
    {
        /// <summary>
        /// 发起人内部需要保存的状态
        /// </summary>
        public State State { get; set; }

        public Originator(State state)
        {
            State = state;
        }
        public Memento CreateMemento()
        {
            // 这里也应该传递深拷贝，可以使用序列化传递State深拷贝
            return new Memento(new State() { Count = State.Count });
        }

        /// <summary>
        /// 设置备忘录，记录此时状态
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            // 下面这种方式是错误的，因为这样只是简单的赋值，如果要保存的状态很多
            //那就会导致代码多且不易于维护
            // 所以应该传递State的深拷贝，深拷贝可以使用序列化来完成
            memento.State.Count = State.Count;
        }

        public void GetMemento(Memento memento)
        {
            // 下面这种方式是错误的，因为这样只是简单的赋值，如果要保存的状态很多
            //那就会导致代码多且不易于维护
            // 所以应该传递State的深拷贝，深拷贝可以使用反序列化来完成
            State.Count = memento.State.Count;
        }

        /// <summary>
        /// 一些操作，改变内部状态
        /// </summary>
        public void DoSomething()
        {
            State.Count = 2;
        }

        public void Print()
        {
            Console.WriteLine($"State->Count={State.Count}");
        }
    }
}
