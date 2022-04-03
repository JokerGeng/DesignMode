using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorMode
{
    public class FontDialogDirector : IDialogDirector
    {
        public Button _ok;
        public Button _cancel;
        public ListBox _fontList;
        public void CreatWidgets()
        {
            _ok = new Button(this);
            _cancel = new Button(this);
            _fontList = new ListBox(this);
        }

        public void ShowDialog()
        {
            throw new NotImplementedException();
        }

        public void WidgetChanged(Widget widget)
        {
            if (widget == _fontList)
            {
                _fontList.SetList();
            }
            else if (widget == _ok)
            {
                _ok.SetText("Ok");
            }
            else if (widget == _cancel)
            {
                _cancel.SetText("Cancel");
            }
        }
    }
}
