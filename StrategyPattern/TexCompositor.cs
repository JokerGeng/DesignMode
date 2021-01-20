using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class TexCompositor:Compositor
    {
        public TexCompositor()
        {

        }

        public override void Compose()
        {
            Console.WriteLine("TexCompositor Compose");
        }

        public override void Compose(Component component)
        {
            Console.WriteLine("TexCompositor Compose Component");
        }
    }
}
