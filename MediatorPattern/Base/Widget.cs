using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Widget
    {
        DialogDirector _director;
        public Widget(DialogDirector director)
        {
            _director = director;
        }

        public virtual void Changed()
        {
            _director.WidgetChanged(this);
        }

        public virtual void HandleMouse(MouseEvent mouseEvent)
        {

        }
    }
}
