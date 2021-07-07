using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Program
{
    class Server
    {   
        public static int MaxUsers { get; private set; }
        public static int Port { get; private set; }
        public static TcpListener serverListener;

        public static void SetupServer(int _maxUsers, int _port)
        {
            MaxUsers = _maxUsers;
            Port = _port;

            serverListener = new TcpListener(IPAddress.Any, Port);

            Console.WriteLine($"Server kuruldu. : Maksimum kullanıcı sayısı: {MaxUsers}, Dinlenen port: {Port}");
        }

        public static void StartServer()
        {
            serverListener.Start();
            Console.WriteLine($"Server başlatıldı. {Port}'unda dinleniyor.");

            serverListener.BeginAcceptTcpClient(AcceptClientCallBack, null);
            Console.WriteLine("Kullanıcılar bekleniyor.");
        }

        public static void AcceptClientCallBack(IAsyncResult asyncResult)
        {
            //Gelen her isteği kabul etme işlemi.
            TcpClient client = serverListener.EndAcceptTcpClient(asyncResult);
            Console.WriteLine($"Bir kullanıcı kabul edildi.{client.Client.RemoteEndPoint}");

            serverListener.BeginAcceptTcpClient(AcceptClientCallBack, null);
        }
    }
}
