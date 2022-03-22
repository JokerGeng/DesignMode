using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMode
{
    public class OpenCommand : ICommand
    {
        Document _document;
        public OpenCommand(Document a)
        {
            _document = a;
        }
        public void Execute()
        {
            _document.Open();
        }

    }
}
