using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DesignMode
{
    public class Chassis:CompositeEquipment
    {
        public Chassis(string name):base(name)
        {

        }

        public override double Power()
        {
            return base.Power();
        }

        public override double NetPrice()
        {
            return base.NetPrice();
        }

        public override double DiscountPrice()
        {
            return base.DiscountPrice();
        }
    }
}
