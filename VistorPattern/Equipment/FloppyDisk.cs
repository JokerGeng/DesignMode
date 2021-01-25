using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class FloppyDisk:Equipment
    {
        public FloppyDisk(string name):base(name)
        {

        }

        public override void Accept(EquipmentVisitor visitor)
        {
            visitor.VisitFloppyDisk(this);
        }

        public override double NetPrice()
        {
            return 1.5;
        }
    }
}
