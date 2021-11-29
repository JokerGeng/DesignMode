using System;

namespace BridgeMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            ExtendedAbstractioA abstractioA = new ExtendedAbstractioA(new ConcreteImplementationA());
            client.ClientOperate(abstractioA);

            Console.WriteLine();
            ExtendedAbstractioB abstractioB = new ExtendedAbstractioB(new ConcreteImplementationB());
            client.ClientOperate(abstractioB);
            Console.Read();

        }
    }
}
