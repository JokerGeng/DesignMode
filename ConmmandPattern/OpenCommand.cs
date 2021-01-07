using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConmmandPattern
{
    public class OpenCommand : Command
    {
        Application _application;
        string _response = null;
        public OpenCommand(Application a)
        {
            _application = a;
        }
        public override void Execute()
        {
            string name = AskUser();
            if (name != null)
            {
                Document document = new Document();
                _application.Add(document);
                document.Open();
            }
        }

        public string AskUser()
        {
            return _response;
        }
    }
}
