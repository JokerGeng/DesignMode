using System;

namespace IteartorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcerteConllection<int> conllection = new ConcerteConllection<int>();
            conllection.Add(1);
            conllection.Add(3);
            conllection.Add(6);
            conllection.Add(4);
            conllection.Add(2);
            conllection.Add(8);
            conllection.Add(7);

            IIterator<int> iterator = conllection.GetIterator();
            while(iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            Console.ReadLine();
        }
    }
}
