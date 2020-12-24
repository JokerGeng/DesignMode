using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPatterns
{
    public class ScrollDecorator: Decorator
    {
        public ScrollDecorator(VisualComponent component):base(component)
        {
            Console.WriteLine("new Scroll");
        }

        public override void Draw()
        {
            Console.WriteLine("Start Draw Scroll");
            base.Draw();
            DrawScroll();
            Console.WriteLine("End Draw Scroll");
        }

        public override void Resize()
        {
            
        }

        void DrawScroll()
        {
            Console.WriteLine("Draw Scroll");
        }
    }
}
