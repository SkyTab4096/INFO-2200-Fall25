using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_AndersonK_Participation03
{
    /// <summary>
    /// Defines the derived flower class from the Plant class
    /// </summary>
    public class Flower : Plant
    {
        // Constructor for the Flower class, passes the values back to the main plant class
        public Flower(string env, string type, string nm) : base(env, type, nm)
        {
            
        }
        // Defines the sniff method to identify which derived class is in use
        public override string Sniff()
        {
            return "I like the smell of flowers";
        }
    }
}
