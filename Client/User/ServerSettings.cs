﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class ServerSettings
    {
        public static string HOST { get; private set; }
        public static int PORT { get; private set; }
        public static void ServerAyarla(string _host, int _port)
        {
            HOST = _host;
            PORT = _port;
        }
    }
}
