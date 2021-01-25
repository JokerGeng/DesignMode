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

            PriceVisitor priceVisitor = new PriceVisitor();
            NameVisitor nameVisitor = new NameVisitor();

            Console.WriteLine($"PriceVisitor initialize price:{priceVisitor.Total}");
            Console.WriteLine("excute equipment accept later:");
            card.Accept(priceVisitor);
            floppyDisk.Accept(priceVisitor);

            Console.WriteLine($"PriceVisitor all Totla:{priceVisitor.Total}");


            card.Accept(nameVisitor);
            floppyDisk.Accept(nameVisitor);

            Console.Read();
        }
    }
}
