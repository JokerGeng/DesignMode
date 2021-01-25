using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipment card = new Card("card");
            Equipment floppyDisk = new FloppyDisk("Disk");

            PriceVisitor visitor = new PriceVisitor();

            Console.WriteLine($"Visitor initialize price:{visitor.Total}");
            Console.WriteLine("excute equipment accept later:");
            card.Accept(visitor);
            floppyDisk.Accept(visitor);

            Console.WriteLine($"Visitor all Totla:{visitor.Total}");
            Console.Read();
        }
    }
}
