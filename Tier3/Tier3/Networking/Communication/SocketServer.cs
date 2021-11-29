using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using Tier3.Networking.Client;
using Tier3.Networking.Utility;

namespace Tier3.Networking.Communication
{
    public class SocketServer
    {
        private static List<TcpClient> _clients;
        private ServerClientHandler _clientHandler;

        public SocketServer()
        {
            _clients = new List<TcpClient>();
            _clientHandler = new ServerClientHandler();
        }

        public void StartServer()
        {
            Console.WriteLine("Starting server ...");
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 2525);
            tcpListener.Start();
            Console.WriteLine("Server started ...");

            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                _clients.Add(tcpClient);
                Console.WriteLine("Client connected");
                new Thread(() => Handle(tcpClient)).Start();
            }
        }

        private void Handle(TcpClient tcpClient)
        {
            NetworkStream stream = tcpClient.GetStream();

            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 1024];
                    int bytesToRead = stream.Read(data, 0, data.Length);
                    string req = Encoding.ASCII.GetString(data, 0, bytesToRead);
                    NetworkPackage req1 = JsonSerializer.Deserialize<NetworkPackage>(req);
                    Console.WriteLine(req1.Content);

                    switch (req1.NetworkType)
                    {
                        case "LOGIN":
                            _clientHandler.GetClient(stream, req1.Content);
                            break;
                        default:
                            string reply = JsonSerializer.Serialize("Tier3");
                            Console.WriteLine(reply);
                            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
                            stream.Write(bytesWrite, 0, bytesWrite.Length);
                            break;
                    }

                    stream.Close();
                    break;
                }
                catch (IOException ioe)
                {
                    _clients.Remove(tcpClient);
                }
            }
        }
    }
}