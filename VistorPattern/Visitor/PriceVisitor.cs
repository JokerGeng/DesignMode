﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class PriceVisitor:EquipmentVisitor
    {
        public double Total { get; set; }

        public override void VisitCard(Card card)
        {
            Total += card.NetPrice();
        }

        public override void VisitFloppyDisk(FloppyDisk floppyDisk)
        {
            Total += floppyDisk.CalPrice();
        }
    }
}
