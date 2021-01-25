using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            View myView = new MyView();
            myView.Display();

            Console.WriteLine();

            View otherView = new OtherView();
            otherView.Display();
            Console.Read();
        }
    }
}
