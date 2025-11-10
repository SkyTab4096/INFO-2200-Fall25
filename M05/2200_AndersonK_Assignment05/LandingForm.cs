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
    public partial class landingForm : Form
    {
        public landingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines the event handler for when the button to open the search form is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Initializes a new instance of the jelly belly form, then displays that form as a dailog box to the user
            JellyBellyForm jbf = new JellyBellyForm();
            jbf.ShowDialog();
        }

        /// <summary>
        /// Defines the event handler for when the button to open the categories form is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            // Initializes a new instance of the categories form, then displays that form as a dailog box to the user
            CategoriesForm cf = new CategoriesForm();
            cf.ShowDialog();
        }

        /// <summary>
        /// Defines the event handler for when the close button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Calls the close method of the form to close the window
            Close();
        }
    }
}
