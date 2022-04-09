using System;

namespace StrategyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            ConcreteStrategyA strategyA = new ConcreteStrategyA();
            ConcreteStrategyB strategyB = new ConcreteStrategyB();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(strategyA);
            context.ExcuteAlgorithm();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(strategyB);
            context.ExcuteAlgorithm();

            Console.Read();
        }
    }
}
