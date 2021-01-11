using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IIterator iterator;
            ConcreteListCollection collection = new ConcreteListCollection();
            iterator = collection.GetIterator();
            while(iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            Console.Read();
        }
    }
}
