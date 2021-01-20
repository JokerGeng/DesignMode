using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCompositor simple = new SimpleCompositor();
            TexCompositor tex = new TexCompositor();
            ArrayCompositor array = new ArrayCompositor();
            Composition composition = new Composition(simple);
            composition.Repair();
            composition.Repair(null);
            Console.WriteLine();
            composition.ChnageStrategy(tex);
            composition.Repair();
            composition.Repair(null);
            Console.WriteLine();
            composition.ChnageStrategy(array);
            composition.Repair();
            composition.Repair(null);

            Console.Read();
        }
    }
}
