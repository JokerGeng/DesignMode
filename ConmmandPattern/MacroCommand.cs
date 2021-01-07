using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConmmandPattern
{
    public class MacroCommand : Command
    {
        List<Command> _cmds = new List<Command>();
        public override void Execute()
        {
            for (int i = 0; i < _cmds.Count; i++)
            {
                _cmds[i].Execute();
            }
        }

        public MacroCommand()
        {

        }

        public void Add(Command com)
        {
            if(!_cmds.Contains(com))
            {
                _cmds.Add(com);
            }
        }

        public void Remove(Command com)
        {
            if (_cmds.Contains(com))
            {
                _cmds.Remove(com);
            }
        }
    }
}
