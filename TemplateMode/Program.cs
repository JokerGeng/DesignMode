using System;

namespace TemplateMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClassA());

            Console.WriteLine();

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClassB());

            Console.Read();
        }
    }
}
