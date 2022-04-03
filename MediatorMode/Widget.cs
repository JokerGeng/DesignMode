using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorMode
{
    public abstract class Widget
    {
        IDialogDirector _director;
        public Widget(IDialogDirector director)
        {
            _director = director;
        }

        public virtual void Changed()
        {
            _director.WidgetChanged(this);
        }

        public abstract void HandleMouse(MouseEvent mouseEvent);
    }
}
