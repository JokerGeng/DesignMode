using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityPattern
{
    public class HelpHandler
    {
        HelpHandler _successor;
        int _topic;
        public HelpHandler(HelpHandler h = null, int t = -1)
        {
            _successor = h;
            _topic = t;
        }

        public virtual bool HasHelp()
        {
            return _topic != -1;
        }

        public virtual void SetHandler(HelpHandler handler, int topic)
        {
            _successor = handler;
            _topic = topic;
        }

        public virtual void HandleHelp()
        {
            if(_successor!=null)
            {
                _successor.HandleHelp();
            }
        }
    }
}
