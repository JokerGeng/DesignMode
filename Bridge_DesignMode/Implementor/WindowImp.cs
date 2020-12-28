using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_DesignMode
{
    public interface WindowImp
    {
         void ImpTop();

         void ImpBottom();

         void ImpSetExtent();

         void ImpSetOrigin();

         void DeviceRect();

         void DeviceText();

         void DeviceBitmap();
    }
}
