using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Button:Widget
    {
        DialogDirector _director;
        public Button(DialogDirector director) : base(director)
        {
            _director = director;
        }

        public void SetText(string type)
        {
            Console.WriteLine($"Button Set {type}");
        }

        public override void HandleMouse(MouseEvent mouseEvent)
        {
            Changed();
        }
    }
}
