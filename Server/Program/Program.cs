using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Server.SetupServer(500, 1234);
            Server.StartServer();
            Console.ReadKey();
        }
    }
}
