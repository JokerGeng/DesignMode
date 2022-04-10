using System;

namespace MediatorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Button _ok;
            Button _cancel;
            ListBox _fontList;

            FontDialogDirector mediator = new FontDialogDirector();
            mediator.CreatWidgets();
            _ok = mediator._ok;
            _cancel = mediator._cancel;
            _fontList = mediator._fontList;

            //模拟操作
            _fontList.Changed();
            //mediator.WidgetChanged(_fontList);

            _ok.HandleMouse(null);
            //mediator.WidgetChanged(_ok);
            _cancel.HandleMouse(null);
            //mediator.WidgetChanged(_cancel);

            Console.Read();
        }
    }
}
