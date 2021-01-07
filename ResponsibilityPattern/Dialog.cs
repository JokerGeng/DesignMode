using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityPattern
{
    public class Dialog:Widget
    {
        public Dialog(HelpHandler h, int t = -1) : base(h as Widget, t)
        {
            SetHandler(h, t);
        }

        public override void HandleHelp()
        {
            if (HasHelp())
            {
                // offer help on the dialog
            }
            else
            {
                base.HandleHelp();
            }
        }
    }
}
