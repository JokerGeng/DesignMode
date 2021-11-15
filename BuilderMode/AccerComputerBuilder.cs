using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    class AccerComputerBuilder : Builder
    {
        Computer computer = new Computer();
        public override void BuildCPU()
        {
            computer.AddPart("Accer CPU");
        }

        public override void BuildMainBoard()
        {
            computer.AddPart("Accer MainBoard");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
