using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class EquipmentVisitor
    {
        public virtual void VisitFloppyDisk(Equipment floppyDisk)
        {

        }

        public virtual void VisitCard(Equipment card)
        {

        }
    }
}
