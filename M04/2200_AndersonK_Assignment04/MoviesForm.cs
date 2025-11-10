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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method updates the data in the dataset when the user clicks off of a selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }

        /// <summary>
        /// This method loads the data from the database into the table when the form is displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.Movie);

        }

        /// <summary>
        /// This method displays the results of the stored procedure from the online database as a dialog box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            CountMovieCategoryForm cmcf = new CountMovieCategoryForm();
            cmcf.ShowDialog();
        }

        /// <summary>
        /// This method sorts the data in the table alphabetically based on the information in the search text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alphaSortBtn_Click(object sender, EventArgs e)
        {
            // Reload the data in the table to filter by search box and sort alphabetically
            this.movieTableAdapter.FillBySearchAlphabetical(this.iNFO2200_CrandallSayDataSet.Movie, searchTxtBox.Text);
        }

        /// <summary>
        /// This method sorts the data in the table reverse alphabetically based on the information in the search text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rAlphaSortBtn_Click(object sender, EventArgs e)
        {
            // Reload the data in the table to filter based on the search text box and sort reverse alphabetically
            this.movieTableAdapter.FillBySearchReverseAlphabetical(this.iNFO2200_CrandallSayDataSet.Movie, searchTxtBox.Text);
        }

        /// <summary>
        /// This method filters the data in the table to only what's in the first 20 rows of the dataset and searched based on the search text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void first20Btn_Click(object sender, EventArgs e)
        {
            // Reload the data in the table to only the first 20 rows of the dataset and only if it matchs what's in the search box
            this.movieTableAdapter.FillBySearchFirst20(this.iNFO2200_CrandallSayDataSet.Movie, searchTxtBox.Text);
        }
    }
}
