using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignMode
{
    public class ApplicationWindow:Window
    {
        
        public ApplicationWindow(View view):base(view)
        {
            
        }

        public override void DrawContents()
        {
            GetView().DrawOn();
        }
    }
}
