using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class Card:Equipment
    {
        public Card(string name):base(name)
        {

        }

        public override void Accept(EquipmentVisitor visitor)
        {
            visitor.VisitCard(this);
        }

        public override double NetPrice()
        {
            return 2.5;
        }
    }
}
