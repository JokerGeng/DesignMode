using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class FontDialogDirector : DialogDirector
    {
        public FontDialogDirector()
        {

        }

        public Button _ok;
        public Button _cancel;
        public ListBox _fontList;
        public EntryField _fontName;

        //实际中不应这么创建同事类，
        //可以结合观察者模式，使用注册方式来添加同事类
        public override void CreatWidgets()
        {
            _ok = new Button(this);
            _cancel = new Button(this);
            _fontList = new ListBox(this);
            _fontName = new EntryField(this);
        }

        public override void ShowDialog()
        {
            
        }

        public override void WidgetChanged(Widget widget)
        {
            if (widget == _fontList)
            {
                _fontList.SetList();
            }
            else if(widget==_fontName)
            {
                _fontName.SetText();
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
