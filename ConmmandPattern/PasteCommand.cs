using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConmmandPattern
{
    public class PasteCommand : Command
    {
        Document _documernt;
        public PasteCommand(Document doc)
        {
            _documernt = doc;
        }
        public override void Execute()
        {
            _documernt.Paste();
        }
    }
}
