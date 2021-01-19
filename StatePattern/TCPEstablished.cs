using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TCPEstablished:TCPState
    {
        private static TCPEstablished instance;

        private static readonly object lcko = new object();

        private TCPEstablished()
        {

        }

        public static TCPEstablished GetInstance()
        {
            if(instance==null)
            {
                lock(lcko)
                {
                    if(instance==null)
                    {
                        instance = new TCPEstablished();
                    }
                }
            }
            return instance;
        }

        public override void Transmit(TCPConnection connection, TCPOctetStream stream)
        {
            connection.ProcessOctet(stream);
        }

        public override void Close(TCPConnection connection)
        {
            ChangedState(connection, TCPListen.GetInstance());
        }
    }
}
