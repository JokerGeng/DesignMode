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

            _ok.HandleMouse(null);
            _cancel.HandleMouse(null);

            Console.Read();
        }
    }
}
