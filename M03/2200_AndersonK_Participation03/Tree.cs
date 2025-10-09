using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_AndersonK_Participation03
{
    /// <summary>
    /// Defines the derived tree class from the Plant class
    /// </summary>
    public class Tree : Plant
    {
        // Constructor for the Tree class, passes the values back to the main plant class
        public Tree(string env, string type, string nm) : base(env, type, nm)
        {

        }

        // Defines the sniff method to identify which derived class is in use
        public override string Sniff()
        {
            return "I like the smell of trees.";
        }
    }
}
