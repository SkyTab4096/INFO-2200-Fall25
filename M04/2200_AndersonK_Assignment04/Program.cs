/*
 * Name: Kory Anderson
 * Class: INFO 2200
 * Section: 001
 * Professor: Sharp
 * Date:
 * Participation or Assignment #:
 * By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by generative AI< unless explicitly stated in the assignment instructions, nor obtained from a subscription service.  I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_AndersonK_Assignment04
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MoviesForm());
        }
    }
}
