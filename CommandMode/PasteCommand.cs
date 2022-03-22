using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMode
{
    public class PasteCommand : ICommand
    {
        Document _documernt;
        public PasteCommand(Document doc)
        {
            _documernt = doc;
        }
        public void Execute()
        {
            _documernt.Paste();
        }
    }
}
