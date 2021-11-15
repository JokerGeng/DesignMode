using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    class DellComputerBuilder : Builder
    {
        Computer computer = new Computer();
        public override void BuildCPU()
        {
            computer.AddPart("Dell CPU");
        }

        public override void BuildMainBoard()
        {
            computer.AddPart("Dell MainBoard");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
