using System;

namespace TCPClientBeer
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Start();
        }
    }
}
