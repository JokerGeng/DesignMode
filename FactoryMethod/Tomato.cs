using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Tomato : Food
    {
        public override void Print()
        {
            Console.WriteLine("炒西红柿");
        }
    }
}
