using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TCPConnection
    {

        TCPState _tcpstate;
        public TCPConnection()
        {
            _tcpstate = TCPClosed.GetInstance();
        }

        public void ActiveOpen()
        {
            _tcpstate.ActiveOpen(this);
        }

        public void PassiveOpen()
        {
            _tcpstate.PassiveOpen(this);
        }

        public void Close()
        {
            _tcpstate.Close(this);
        }

        public void Send()
        {

        }

        public void Acknowledge()
        {
            _tcpstate.Acknowledge(this);
        }

        public void Synchronize()
        {
            _tcpstate.Synchronize(this);
        }

        public void ProcessOctet(TCPOctetStream stream)
        {

        }

        public void ChangedState(TCPState state)
        {
            Console.WriteLine($"{_tcpstate.GetType().Name} changed to {state.GetType().Name}");
            _tcpstate = state;
        }
    }
}
