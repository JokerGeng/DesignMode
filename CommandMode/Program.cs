using System;

namespace CommandMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Document doc = new Document();

            ICommand open = new OpenCommand(doc);

            invoker.SetCommand(open);
            invoker.ExecuteCommand();


            ICommand paste = new PasteCommand(doc);
            //invoker.SetCommand(paste);
            //invoker.ExecuteCommand();
            invoker.ExecuteCommand(paste);

            Console.Read();
        }
    }
}
