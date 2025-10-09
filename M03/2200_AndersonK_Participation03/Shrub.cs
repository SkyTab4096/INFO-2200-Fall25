using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_AndersonK_Participation03
{
    /// <summary>
    /// Defines the derived shrub class from the Plant class
    /// </summary>
    public class Shrub : Plant
    {
        // Constructor for the Shrub class, passes the values back to the main plant class
        public Shrub(string env, string type, string nm) : base(env, type, nm)
        {
            
        }
        // Defines the sniff method to identify which derived class is in use
        public override string Sniff()
        {
            return "I like the smell of shrubs.";
        }
    }
}
