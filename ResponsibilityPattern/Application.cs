using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityPattern
{
    public class Application:HelpHandler
    {
        public Application(int topic):base(null,topic)
        {

        }
        public override void HandleHelp()
        {
            // show a list of help topics
        }
    }
}
