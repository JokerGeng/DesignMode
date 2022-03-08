using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeMode
{
    public class SubSystem1
    {
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}
