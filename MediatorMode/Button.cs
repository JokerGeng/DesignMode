using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorMode
{
    public class Button:Widget
    {
        public Button(IDialogDirector director) : base(director)
        {
            
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
