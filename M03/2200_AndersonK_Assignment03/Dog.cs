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
    public class Dog : Animal
    {
        /// <summary>
        /// Constructor for the dog class which then passes values back the the base class
        /// </summary>
        /// <param name="skinType"></param>
        /// <param name="foodType"></param>
        public Dog(string skinType, string foodType) : base(skinType, foodType)
        {
            
        }

        // Defines the unique method that overrides the unique method of the base class
        public override string unique()
        {
            return "Wags tail";
        }

        // Defines the move method that then overrides the move method of the base class
        public override string move()
        {
            return "Prances";
        }
    }
}
