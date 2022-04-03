using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorMode
{
    public interface IDialogDirector
    {
        void ShowDialog();

        void WidgetChanged(Widget widget);

        void CreatWidgets();
    }
}
