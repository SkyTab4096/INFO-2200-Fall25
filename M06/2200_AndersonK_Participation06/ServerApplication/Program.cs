using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Kory's Joke/Conspiracy Server");
            Console.WriteLine("----------------------------------------");

            SychonousSocketListener ssl = new();
            ssl.StartListening();
        }
    }
}