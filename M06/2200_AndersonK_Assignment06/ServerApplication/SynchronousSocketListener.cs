using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication
{
    internal class SynchronousSocketListener
    {
        const int SERVER_PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";
        const string FACT = "UVUFACT";
        const string MAJOR = "UVUMAJOR";
        string[]? facts;
        string[]? majors;
        const string FACT_FILE = "UVUFacts.txt";
        const string MAJOR_FILE = "UVUCourseDescriptions.txt";
        TcpListener listener;

        public SynchronousSocketListener()
        {
            try
            {
                facts = File.ReadAllLines(FACT_FILE);
                majors = File.ReadAllLines(MAJOR_FILE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StartSession()
        {
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);
            listener = new(iPAddress, SERVER_PORT);
            listener.Start();
            Thread thread = new(new ThreadStart(ProcessSocket));
            thread.Start();
        }

        public void ProcessSocket()
        {
            while (true) {
                try
                {
                    Socket socket = listener.AcceptSocket();
                    NetworkStream ns = new(socket);
                    StreamReader reader = new(ns);
                    StreamWriter writer = new(ns);

                    writer.AutoFlush = true;
                    string? ClientInput = reader.ReadLine();
                    Console.WriteLine($"Received from client: {ClientInput}");

                    Random rand = new();
                    if (ClientInput != null)
                    {
                        if (ClientInput.ToUpper() == FACT)
                        {
                            string fact = facts[rand.Next(0, facts.Length)];
                            Console.WriteLine(fact);
                            writer.WriteLine(fact);
                        }
                        else if (ClientInput.ToUpper() == MAJOR)
                        {
                            string major = majors[rand.Next(0, majors.Length)];
                            Console.WriteLine(major);
                            writer.WriteLine(major);
                        }
                        else
                        {
                            string error = $"Unable to do anything with: {ClientInput}";
                            Console.WriteLine(error);
                            writer.WriteLine(error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
