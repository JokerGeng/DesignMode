using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_DesignPatterns
{
    public class Window
    {
        public Window()
        {

        }

        public void SetContents(VisualComponent component)
        {
            component.Draw();
        }
    }

    public class TextView:VisualComponent
    {
        public TextView()
        {

        }

        public override void Draw()
        {
            
        }

        public override void Resize()
        {
            
        }
    }
}
