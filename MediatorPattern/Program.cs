using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Button _ok;
            Button _cancel;
            ListBox _fontList;
            EntryField _fontName;

            FontDialogDirector mediator = new FontDialogDirector();
            mediator.CreatWidgets();
            _ok = mediator._ok;
            _cancel = mediator._cancel;
            _fontList = mediator._fontList;
            _fontName = mediator._fontName;

            //模拟操作
            _fontList.Changed();
            _fontName.Changed();

            _ok.HandleMouse(null);
            _cancel.HandleMouse(null);

            Console.Read();
        }
    }
}
