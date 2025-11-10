using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_AndersonK_Assignment05
{
    public partial class JellyBellyForm : Form
    {
        // Initializes a connection to the database
        JellyBellyDB db = new JellyBellyDB();
        public JellyBellyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines the event handler for when the search button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Gets the jelly belly flavors that match the value that the user entered
            List<JellyBelly> filteredFlavors = db.JellyBellies.Where(flavor => flavor.jellyBellyFlavor.Contains(searchTxtBox.Text)).ToList();

            // Sets the data in the data grid view to be the filtered jelly belly flavors
            jellyBellyFlavorsDGV.DataSource = filteredFlavors;
        }

        /// <summary>
        /// Defines the event handler for when the show all button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            // Calls a method to reload the data grid view
            LoadDataGridView();
        }

        /// <summary>
        /// Defines the event handler for when the close button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Calls the close method of the windows form to close the window
            Close();
        }

        /// <summary>
        /// Defines the event handler for when the text in the search box is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Gets the jelly belly flavors that match the value the user entered
            List<JellyBelly> filteredFlavors = db.JellyBellies.Where( flavor => flavor.jellyBellyFlavor.Contains(searchTxtBox.Text) ).ToList();

            // Sets the data in the data grid view to be the filtered jelly belly flavors
            jellyBellyFlavorsDGV.DataSource = filteredFlavors;
        }

        /// <summary>
        /// Defines the event handler for when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JellyBellyForm_Load(object sender, EventArgs e)
        {
            // Calls a method to load the data into the data grid view
            LoadDataGridView();

        }

        /// <summary>
        /// Define a method to load the data into the data grid view
        /// </summary>
        private void LoadDataGridView()
        {
            // Gets all jelly belly flavors from the data base then stores it in the data grid view
            List<JellyBelly> jellyBellies = db.JellyBellies.ToList();
            jellyBellyFlavorsDGV.DataSource = jellyBellies;

            // Sets up the columns for the data grid view
            jellyBellyFlavorsDGV.Columns[0].Visible = false;
            jellyBellyFlavorsDGV.Columns[1].HeaderCell.Value = "Flavor";
            jellyBellyFlavorsDGV.Columns[2].Width = 200;
            jellyBellyFlavorsDGV.Columns[2].HeaderCell.Value = "Flavor Category";
        }
    }
}
