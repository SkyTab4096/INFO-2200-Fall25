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
    public partial class CategoriesForm : Form
    {
        ProductDB productDB = new ProductDB();
        public CategoriesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines the event handler for when the categories form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // Adds the column headers to the list view
            categoriesLstView.Columns.Add("Category");
            categoriesLstView.Columns.Add("Count");

            // Adds items to the list view for each category of item
            //List<CatTotal> catTotals = (from cat in productDB.Products
            //                            group cat.Category by cat.Category into cats
            //                            select new CatTotal { ProdCat = cats.Key, CatCount = cats.Count() }).ToList();
            //List < CatTotal > = productDB.Products.GroupBy(cat => cat.Category).Select(cats => new CatTotal { ProdCat = cats.Key, CatCount = cats.Count() }).ToList();
            //foreach (CatTotal item in catTotals)
            //{
            //    string[] listitems = {item.ProdCat, item.CatCount.ToString()};
            //    ListViewItem lvi = new ListViewItem(listitems);
            //    categoriesLstView.Items.Add(lvi);
            //}

            // Resizes the columns to take up the full width given
            categoriesLstView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            categoriesLstView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

            // Displays an error message since the table in the downloaded database does not contain the Catagory Column
            MessageBox.Show("Category Column not defined in the downloaded database");
        }
    }

    /// <summary>
    /// Creates a new class to contain the information for each category
    /// </summary>
    public class CatTotal
    {
        // Creates the data types that are stored in the category count class
        public string ProdCat {  get; set; }
        public int CatCount { get; set; }
    }
}
