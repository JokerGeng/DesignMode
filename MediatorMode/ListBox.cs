using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorMode
{
    public class ListBox : Widget
    {
        public ListBox(IDialogDirector director):base(director)
        {

        }
        public override void HandleMouse(MouseEvent mouseEvent)
        {
            
        }

        public void  GetSelection()
        {
            Console.WriteLine("ListBox GetSelection");
        }

        public void SetList()
        {
            Console.WriteLine("ListBox SetList");
        }
    }
}
