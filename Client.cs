using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TCPClientBeer
{
    public class Client
    {
        public void Start()
        {
            Console.WriteLine("press enter");
            Console.ReadLine();
            TcpClient socket = new TcpClient("localhost", 4646);

            Stream ns = socket.GetStream();

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;
            Console.WriteLine("write a message");
            string line = Console.ReadLine();
            sw.WriteLine(line);
            string serveranswer = sr.ReadLine();
            Console.WriteLine("Server: " + serveranswer);
            Console.ReadLine();

            ns.Close();
            socket.Close();
        }

    }
}
