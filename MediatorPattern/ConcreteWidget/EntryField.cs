using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class EntryField:Widget
    {
        DialogDirector _director;
        public EntryField(DialogDirector director):base(director)
        {
            _director = director;
        }

        public void SetText()
        {
            Console.WriteLine("EntryField Set Text");
        }

        public override void HandleMouse(MouseEvent mouseEvent)
        {
            
        }
    }
}
