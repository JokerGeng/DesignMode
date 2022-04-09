using System;

namespace StateMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            ConcreteStateA stateA = new ConcreteStateA();


            context.SetState(stateA);
            context.Request1();
            context.Request2();

            Console.Read();
        }
    }
}
