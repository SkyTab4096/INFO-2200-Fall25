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
    public partial class CategoriesForm : Form
    {
        // Initializes a connecntion to the database
        JellyBellyDB db = new JellyBellyDB();
        public CategoriesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines the event handler for when the close button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Closes the current window form
            Close();
        }

        /// <summary>
        /// Defines the event handler for when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // Adds the headers to the list view object
            categoriesListView.Columns.Add("Category");
            categoriesListView.Columns.Add("Number");

            // Gets all the categories from the database
            var jbCat = from j in db.JellyBellies
                        group j by j.category into x
                        orderby x.Count() descending
                        select x;

            // Starts a loop for every categorie
            foreach (IGrouping<String,JellyBelly> ct in jbCat)
            {
                // Store the categories and a count of how many entries have that category in a string array
                String[] listValues = { ct.Key, ct.Count().ToString() };
                // Converts the string array into a list view item to be added to the list view
                ListViewItem lvi = new ListViewItem(listValues);
                // Adds the new list view item into the list view
                categoriesListView.Items.Add(lvi);
            }

            // Resizes the columns in the list view
            categoriesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            categoriesListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
