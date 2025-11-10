using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_AndersonK_Participation05
{
    public partial class landingForm : Form
    {
        public landingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines the event handler for when the button to display the Products View Form is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the product search form and display it to the user
            ProductSearchForm productSearchForm = new ProductSearchForm();
            productSearchForm.ShowDialog();
        }

        /// <summary>
        /// Defines the event handler for when the button to display the categories count view form is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupByBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the categories count form and display it to the user
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.ShowDialog();
        }
    }
}
