using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class MyView:View
    {
        protected override void DoDisplay()
        {
            Console.WriteLine("MyView display");
        }
    }
}
