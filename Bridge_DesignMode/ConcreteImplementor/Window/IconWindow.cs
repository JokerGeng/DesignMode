using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignMode
{
    public class IconWindow:Window
    {
        public IconWindow(View view):base(view)
        {

        }

        public override void DrawContents()
        {
            WindowImp imp = GetWindowImp();
            if(imp!=null)
            {
                imp.DeviceBitmap();
            }
        }

    }
}
