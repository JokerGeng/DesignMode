using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MementoMode
{
    public class Originator
    {
        private string _state;

        public Originator(string state)
        {
            _state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        //创建一个备忘录,记录当前时刻的状态
        public IMemento Save()
        {
            return new ConcreteMemento(_state);
        }

        //使用备忘录恢复内部状态
        public void Restore(IMemento memento)
        {
            if(!(memento is ConcreteMemento))
            {
                Console.WriteLine("Unknown memento class " + memento.ToString());
            }
            else
            {
                _state = memento.GetState();
                Console.Write($"Originator: My state has changed to: {_state}");
            }
        }

        //做某些事情改变了本身的状态
        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }
    }
}
