using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Potato : Food
    {
        public override void Print()
        {
            Console.WriteLine("炒土豆");
        }
    }
}
