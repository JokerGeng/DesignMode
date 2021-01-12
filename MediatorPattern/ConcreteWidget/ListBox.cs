using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ListBox : Widget
    {
        DialogDirector _director;
        public ListBox(DialogDirector director):base(director)
        {
            _director = director;
        }

        public void SetList()
        {
            Console.WriteLine("ListBox Set List");
        }

        public override void HandleMouse(MouseEvent mouseEvent)
        {
            
        }
    }
}
