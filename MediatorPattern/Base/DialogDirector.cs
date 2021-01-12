using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class DialogDirector
    {
        public abstract void ShowDialog();

        public abstract void WidgetChanged(Widget widget);

        public abstract void CreatWidgets();
    }
}
