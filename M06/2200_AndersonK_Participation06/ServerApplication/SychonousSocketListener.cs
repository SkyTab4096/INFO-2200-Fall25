using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication
{
    public class SychonousSocketListener
    {
        const int PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";
        const string JOKE = "JOKE";
        const string CONSPIRACY = "CONSPIRACY";
        string[] jokes;
        string[] conspriacies;
        const string JOKE_FILE = "jokes.txt";
        const string CONSP_FILE = "conspiracies.txt";
        TcpListener tcpListener;

        public SychonousSocketListener()
        {
            try
            {
                jokes = File.ReadAllLines(JOKE_FILE);
                conspriacies = File.ReadAllLines(CONSP_FILE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void StartListening()
        {
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);
            tcpListener = new(iPAddress, PORT);
            tcpListener.Start();
            Thread thread = new(new ThreadStart(ProcessSocket));
            thread.Start();
        }

        public void ProcessSocket()
        {
            while (true)
            {
                try
                {
                    Socket socket = tcpListener.AcceptSocket();
                    NetworkStream ns = new NetworkStream(socket);
                    StreamReader reader = new StreamReader(ns);
                    StreamWriter writer = new StreamWriter(ns);

                    writer.AutoFlush = true;

                    string? clientInput = reader.ReadLine();
                    Console.WriteLine($"Received from client: {clientInput}");

                    Random rand = new Random();
                    if (clientInput != null)
                    {
                        if (clientInput.ToUpper() == JOKE)
                        {
                            string joke = jokes[rand.Next(jokes.Length)];
                            Console.WriteLine(joke);
                            writer.WriteLine(joke);
                        }
                        else if (clientInput.ToUpper() == CONSPIRACY)
                        {
                            string conspiracy = conspriacies[rand.Next(conspriacies.Length)];
                            Console.WriteLine(conspiracy);
                            writer.WriteLine(conspiracy);
                        }
                        else
                        {
                            Console.WriteLine($"Could not do anything with: {clientInput}");
                            writer.WriteLine($"Could not do anything with: {clientInput}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
