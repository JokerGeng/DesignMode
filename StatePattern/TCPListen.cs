using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TCPListen:TCPState
    {
        private static TCPListen instance;

        private static readonly object lcko = new object();

        private TCPListen()
        {

        }

        public static TCPListen GetInstance()
        {
            if (instance == null)
            {
                lock (lcko)
                {
                    if (instance == null)
                    {
                        instance = new TCPListen();
                    }
                }
            }
            return instance;
        }

        public override void Send(TCPConnection connection)
        {
            ChangedState(connection, TCPEstablished.GetInstance());
        }
    }
}
