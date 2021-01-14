using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //发起者本身要保存的数据
            State state = new State() { Count = 0 };

            //发起者
            Originator originator = new Originator(state);

            //负责人
            Caretaker caretaker = new Caretaker();
            caretaker.Memento=originator.CreateMemento();

            Console.WriteLine("初始状态");
            originator.Print();

            //设置备忘录，保存当前状态
            originator.SetMemento(caretaker.Memento);

            originator.DoSomething();
            Console.WriteLine("执行一些操作后状态");
            originator.Print();

            originator.GetMemento(caretaker.Memento);

            Console.WriteLine("使用备忘录恢复后状态");
            originator.Print();

            Console.Read();
        }
    }
}
