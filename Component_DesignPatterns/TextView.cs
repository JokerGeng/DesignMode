using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPatterns
{
    public class TextView:VisualComponent
    {
        public TextView()
        {

        }

        public override void Draw()
        {
            Console.WriteLine("TextView Draw");
        }

        public override void Resize()
        {
            
        }
    }
}
