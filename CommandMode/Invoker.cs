using System;
using System.Collections.Generic;
using System.Text;

namespace CommandMode
{
    public class Invoker
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
