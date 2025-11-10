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
    public partial class ProductSearchForm : Form
    {
        ProductDB productDB = new ProductDB();
        public ProductSearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines the event handler for when the button to add a new product is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            // Creates a new instance of the add product form and displays it to the user
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();

            // Reloads the data grid view to include the item the user added
            LoadDataGridView();
        }

        /// <summary>
        /// Defines the event handler for when the button to delete a product is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            // Attempts to find the selected product in the database
            Product findProd = productDB.Products.FirstOrDefault(prod => prod.Product_Number == deleteProductCB.SelectedItem.ToString());
            
            // Checks to make sure that a product was actually found in the database
            if (findProd != null) { 
                // Deletes the selected product
                productDB.Products.Remove(findProd);
                productDB.SaveChanges();

                // Display a success message
                MessageBox.Show($"{findProd.Product_Number} was deleted from the database.");
                
                // Reload the data grid view to show the updated information
                LoadDataGridView();
            }
            else
            {
                // Display an error message, that the selected item was not found
                MessageBox.Show($"Could not find {deleteProductCB.SelectedItem.ToString()} in the database");
            }
        }

        /// <summary>
        /// Defines the event hander for when the user types in the filter text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productDescriptionTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Finds all products in the database that fit the filter typed by the user
            List<Product> filteredProducts = (from prod in productDB.Products
                                              where prod.Description.Contains(productDescriptionTxtBox.Text)
                                              select prod).ToList();
            //List<Product> linqmethod = productDB.Products.Where( prod => prod.Description.Contains(productDescriptionTxtBox.Text) ).ToList();

            // Reload the data grid view with filtered information
            dataGridView1.DataSource = filteredProducts;
        }

        /// <summary>
        /// Defines the event handler for when the product search form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            // Loads the data from the database into the data grid view
            LoadDataGridView();
        }

        /// <summary>
        /// Defines the method to load the data from the database into the datagrid view
        /// </summary>
        private void LoadDataGridView()
        {
            // Gets all products from the database
            List<Product> products = productDB.Products.ToList();

            // Loads the products into the database, and the delete item combobox
            dataGridView1.DataSource = products;
            deleteProductCB.Items.Clear();
            deleteProductCB.Items.AddRange(products.Select(prod => prod.Product_Number).ToArray());
        }
    }
}
