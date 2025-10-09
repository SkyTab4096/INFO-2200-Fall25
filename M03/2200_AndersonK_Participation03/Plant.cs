using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_AndersonK_Participation03
{
    // Defines the plant class to be used throughout the project
    public class Plant
    {
        // Initialize some private variables to be used in this class exclusivly
        private string _enviroment;
        private string _type;
        private string _name;
        
        /// <summary>
        /// Constructor for the plant class
        /// </summary>
        /// <param name="env"></param>
        /// <param name="type"></param>
        /// <param name="nm"></param>
        public Plant( string env, string type, string nm)
        {
            _enviroment = env;
            _type = type;
            _name = nm;
        }
        // Sets up the environment variable in the class
        public string environment
        {
            get { return _enviroment; }
            set { _enviroment = value; }
        }
        // Sets up the type variable in the class
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        // Sets up the name variable in the class
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        // Defines a sniff method for the generic plant class
        public virtual string Sniff()
        {
            return "Let's sniff plants.";
        }
    }
}
