using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class Equipment
    {
        protected Equipment( string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public virtual void Accept(EquipmentVisitor visitor)
        {
            
        }
        

        public virtual double NetPrice()
        {
            return 0;
        }

    }
}
