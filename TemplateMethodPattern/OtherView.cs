using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class OtherView:View
    {
        protected override void DoDisplay()
        {
            Console.WriteLine("OtherView display");
        }
    }
}
