using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerSettings.ServerAyarla("127.0.0.1", 1234);
            Client.Connect();
            Console.ReadKey();

            
        }
    }
}
