using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _2200_AndersonK_Participation06
{
    public class SynchonousSocketClient
    {
        const int SERVER_PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";

        public SynchonousSocketClient()
        {
            
        }

        public string ContactServer(string request)
        {
            string responseString = "";
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), SERVER_PORT);
                NetworkStream networkStream = tcpClient.GetStream();

                StreamReader streamReader = new StreamReader(networkStream);
                StreamWriter streamWriter = new StreamWriter(networkStream);

                streamWriter.AutoFlush = true;
                streamWriter.WriteLine(request);
                responseString = streamReader.ReadLine();

                networkStream.Close();
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
