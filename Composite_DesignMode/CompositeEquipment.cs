using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DesignMode
{
    public class CompositeEquipment : Equipment
    {
        List<Equipment> equipments = new List<Equipment>();
        public CompositeEquipment(string name):base(name)
        {

        }

        public override double Power()
        {
            return 0;
        }

        public override double NetPrice()
        {
            Iterator<Equipment> iterator = new Iterator<Equipment>(equipments);
            double total = 0;
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                total += iterator.Current().NetPrice();
            }
            return total;
        }

        public override double DiscountPrice()
        {
            return 0;
        }

        public override void Add(Equipment equipment)
        {
            if(!equipments.Contains(equipment))
            {
                equipments.Add(equipment);
            }
        }

        public override void Remove(Equipment equipment)
        {
            if (equipments.Contains(equipment))
            {
                equipments.Remove(equipment);
            }
        }

        public override Iterator<Equipment> CreateIterator()
        {
            return new Iterator<Equipment>();
        }
    }

}
