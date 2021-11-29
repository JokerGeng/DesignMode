using System;

namespace BuilderMode
{
    //建造者模式将一个复杂对象的表示与它的构建相分离，使得同样的构建过程可以创建不同的表示
    class Program
    {
        static void Main(string[] args)
        {
            var dellBuilder = new DellComputerBuilder();
            new Director().CreatComputer(dellBuilder);
            var dellComputer = dellBuilder.GetComputer();
            dellComputer.ShowComputer();

            Console.WriteLine();

            var accerBuilder = new AccerComputerBuilder();
            new OtherDirector().CreatComputer(accerBuilder);
            var accerComputer = accerBuilder.GetComputer();
            accerComputer.ShowComputer();

            Console.WriteLine();
            Console.WriteLine();


            var dellBuilder1 = new DellComputerBuilder();
            var accerBuilder1 = new AccerComputerBuilder();

            Director director = new Director();
            director.CreatComputer(dellBuilder1);
            dellComputer = dellBuilder1.GetComputer();
            dellComputer.ShowComputer();

            Console.WriteLine();
            Console.WriteLine();

            director.CreatComputer(accerBuilder1);
            accerComputer = accerBuilder1.GetComputer();
            accerComputer.ShowComputer();

            Console.Read();
        }
    }
}
