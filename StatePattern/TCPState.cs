using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TCPState
    {
        public virtual void Transmit(TCPConnection connection,TCPOctetStream stream)
        {

        }

        public virtual void ActiveOpen(TCPConnection connection)
        {

        }

        public virtual void PassiveOpen(TCPConnection connection)
        {

        }

        public virtual void Close(TCPConnection connection)
        {
            Console.WriteLine("Close tcp");
        }

        public virtual void Send(TCPConnection connection)
        {

        }

        public virtual void Acknowledge(TCPConnection connection)
        {

        }

        public virtual void Synchronize(TCPConnection connection)
        {

        }

        protected virtual void ChangedState(TCPConnection connection, TCPState state)
        {
            connection.ChangedState(state);
        }
    }
}
