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
    public class Horse : Animal
    {
        /// <summary>
        /// Constructor for the horse class that then passes back values to the base class
        /// </summary>
        /// <param name="skinType"></param>
        /// <param name="foodType"></param>
        public Horse(string skinType, string foodType) : base(skinType, foodType)
        {
            
        }

        // Defines the unique method that then overrides the unique method of the base class
        public override string unique()
        {
            return "Flicks tail";
        }

        // Defines the move method that then overrrides the move method of the base class
        public override string move()
        {
            return "Runs";
        }
    }
}
