using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPConnection tcp = new TCPConnection();
            tcp.ActiveOpen();
            tcp.ChangedState(TCPListen.GetInstance());
            tcp.Close();
            Console.Read();
        }
    }
}
