using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class NameVisitor:EquipmentVisitor
    {
        public override void VisitCard(Card card)
        {
            Console.WriteLine($"I am {card.Name}");
        }

        public override void VisitFloppyDisk(FloppyDisk floppyDisk)
        {
            Console.WriteLine($"I am {floppyDisk.Name}");
        }
    }
}
