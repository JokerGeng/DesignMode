using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityPattern
{
    public class Button:Widget
    {
        public Button(Widget d,int t=-1) : base(d, t)
        {

        }

        public override void HandleHelp()
        {
            if(HasHelp())
            {
                // offer help on the button
            }
            else
            {
                base.HandleHelp();
            }
        }
    }
}
