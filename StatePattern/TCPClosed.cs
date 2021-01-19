using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TCPClosed:TCPState
    {
        private static TCPClosed instance;

        private static readonly object lcko = new object();

        private TCPClosed()
        {

        }

        public static TCPClosed GetInstance()
        {
            if (instance == null)
            {
                lock (lcko)
                {
                    if (instance == null)
                    {
                        instance = new TCPClosed();
                    }
                }
            }
            return instance;
        }

        public override void ActiveOpen(TCPConnection connection)
        {
            ChangedState(connection, TCPEstablished.GetInstance());
        }

        public override void PassiveOpen(TCPConnection connection)
        {
            ChangedState(connection, TCPListen.GetInstance());
        }
    }
}
