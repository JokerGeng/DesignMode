using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ArrayCompositor:Compositor
    {
        public ArrayCompositor()
        {

        }

        public override void Compose()
        {
            Console.WriteLine("ArrayCompositor Compose");
        }

        public override void Compose(Component component)
        {
            Console.WriteLine("ArrayCompositor Compose Component");
        }
    }
}
