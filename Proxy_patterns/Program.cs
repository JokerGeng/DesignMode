using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TextDocument text = new TextDocument();
            text.Insert(new ImageProxy("anImageFileName"));
        }
    }
}
