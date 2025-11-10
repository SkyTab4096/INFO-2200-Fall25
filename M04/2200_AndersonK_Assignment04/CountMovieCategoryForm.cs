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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_AndersonK_Assignment04
{
    public partial class CountMovieCategoryForm : Form
    {
        public CountMovieCategoryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method displays the results of the stored procedure from the online database as a table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountMovieCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayStoredProcedure.CountMovieCategory' table. You can move, or remove it, as needed.
            this.countMovieCategoryTableAdapter.Fill(this.iNFO2200_CrandallSayStoredProcedure.CountMovieCategory);

        }
    }
}
