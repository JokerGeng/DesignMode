using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class PriceVisitor:EquipmentVisitor
    {
        public double Total { get; set; }

        public override void VisitCard(Equipment card)
        {
            Total += card.NetPrice();
        }

        public override void VisitFloppyDisk(Equipment floppyDisk)
        {
            Total += floppyDisk.NetPrice();
        }
    }
}
