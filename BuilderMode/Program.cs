using System;

namespace BuilderMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            var dellBuilder = new DellComputerBuilder();
            var dellComputer = director.CreatComputer(dellBuilder);
            dellComputer.ShowComputer();

            Console.WriteLine();

            var accerBuilder = new AccerComputerBuilder();
            var accerComputer = director.CreatComputer(accerBuilder);
            accerComputer.ShowComputer();

            Console.Read();
        }
    }
}
