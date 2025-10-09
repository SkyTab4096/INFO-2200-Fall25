/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: October 8, 2025
Participation or Assigment: 03
By submitting this assignment, I declare that the source code in this assignment was written solely by me, unless specified by the assignment.  I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicatly stated in the assignment instructions, nor from a subscription service.  I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will recieve a zero on this project if I am found in violation of this policy.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_AndersonK_Assignment03
{
    // Create a new base class for all the animal classes to be derived from
    public class Animal
    {
        // Initialize new private variables for skin type and food type
        private string _skinType;
        private string _foodType;

        // Constructor for the animal class, sets the private varibles equal to the values passed in
        public Animal(string skinType, string foodType)
        {
            _skinType = skinType;
            _foodType = foodType;
        }

        // Sets up the skin type variable
        public string skinType
        {
            get { return _skinType; }
            set { _skinType = value; }
        }

        // Sets up the food type variable
        public string foodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }

        // Defines the eat method for the class
        public string eat()
        {
            return "Chomp";
        }

        // Defines the reproduce method for the class
        public string reproduce()
        {
            return "Create offspring";
        }

        // Sets up the move method for the class to then be overwritten
        public virtual string move()
        {
            return "Clop";
        }

        // Sets up the unique method for the class to then be overwritten
        public virtual string unique()
        {
            return "Unquie Action";
        }
    }
}
