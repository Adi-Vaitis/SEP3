﻿using System;
using System.Threading.Tasks;
using Tier3.Networking.Communication;

namespace Tier3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SocketServer socketServer = new SocketServer();
            socketServer.StartServer();
            Console.WriteLine("This is just a test to see if everything else messed up");

        }
    }
}