using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication
{
    public class SynchronousSocketClient
    {
        const int SERVER_PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";

        public SynchronousSocketClient()
        {
            
        }

        public string ContactServer(string request)
        {
            string responseString = "";
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);

            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(iPAddress, SERVER_PORT);
                NetworkStream ns = tcpClient.GetStream();

                StreamReader reader = new StreamReader(ns);
                StreamWriter writer = new StreamWriter(ns);

                writer.AutoFlush = true;
                writer.WriteLine(request);
                responseString = reader.ReadLine();

                ns.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                responseString = ex.Message;
            }
            return responseString;
        }
    }
}
