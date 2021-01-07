using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConmmandPattern
{
    public class Application
    {
        List<Document> documents = new List<Document>();
        public Application()
        {

        }

        public void Add(Document document)
        {
            if(!documents.Contains(document))
            {
                documents.Add(document);
            }
        }
    }
}
