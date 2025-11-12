using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication
{
    public class TempServer
    {
        Random rand = new Random();
        string[] jokes;
        string[] conspiracies;
        const string JOKE_FILE = "jokes.txt";
        const string CONSP_FILE = "conspiracies.txt";
        public TempServer()
        {
            
        }

        public void LoadFiles()
        {
            try
            {
                jokes = File.ReadAllLines(JOKE_FILE);
                conspiracies = File.ReadAllLines(CONSP_FILE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GetRandomJoke()
        {
            return jokes[rand.Next(jokes.Length)];
        }

        public string GetRandomConsp()
        {
            return conspiracies[rand.Next(conspiracies.Length)];
        }
    }
}
