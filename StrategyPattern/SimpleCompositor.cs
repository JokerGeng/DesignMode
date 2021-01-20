using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SimpleCompositor:Compositor
    {
        public SimpleCompositor():base()
        {
            
        }

        public override void Compose()
        {
            Console.WriteLine("SimpleCompositor Compose");
        }

        public override void Compose(Component component)
        {
            Console.WriteLine("SimpleCompositor Compose Component");
        }
    }
}
