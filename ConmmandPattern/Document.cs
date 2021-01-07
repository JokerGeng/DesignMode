using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConmmandPattern
{
    public class Document
    {
        public void Open()
        {
            Console.WriteLine("Document Open");
        }

        public void Paste()
        {
            Console.WriteLine("Document Paste");
        }
    }
}
