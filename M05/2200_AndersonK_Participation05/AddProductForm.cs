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
    public partial class AddProductForm : Form
    {
        // Create a new connection to the database
        ProductDB db = new ProductDB();
        public AddProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines the event handler for the form to add a new product is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // Add the categories to the selection combo box, with an option to create a new category
            categoryCB.Items.Add("New Category");
            //var catItems = (from cat in db.Products
                            //where cat.Category != null
                            //group cat.Category by cat.Category into c
                            //select new { Category = c.Key });
            //categoryCB.Items.AddRange(catItems.Select(cats => cats.Category).ToArray());
        }

        /// <summary>
        /// Defines the event handler for when the user changes the selected item in the category combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks to see if the user selected the first index in the combo box, which should be the new category option
            if (categoryCB.SelectedIndex == 0)
            {
                // Display the label and textbox to create a new category
                newLbl.Show();
                newTxtBox.Show();
            } 
            else
            {
                // Hide the label and textbox to create a new category
                newLbl.Hide();
                newTxtBox.Hide();
            }
        }

        /// <summary>
        /// Defines the event handler for when the button to add a new product is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Initializes the variables used to create a new product
            decimal price;
            int units;
            string cat = "";

            // Checks to make sure that all entered values are valid
            if (descriptionTxtBox.Text != "" && decimal.TryParse(priceTxtBx.Text, out price) && int.TryParse(unitsTxtBx.Text, out units) && categoryCB.SelectedIndex > -1)
            {
                // Creates a new object with the values that the user selected
                Product newProd = new Product
                {
                    //Category = categoryCB.SelectedIndex == 0 ? newTxtBox.Text : categoryCB.SelectedItem.ToString(),
                    Description = descriptionTxtBox.Text,
                    Price = price,
                    Product_Number = productNumberTxtBx.Text,
                    Units_On_Hand = units
                };

                // Adds the new product object to the database
                db.Products.Add(newProd);
                db.SaveChanges();

                // Displays a success message
                MessageBox.Show($"{newProd.Product_Number} was just added to the database");
                Close();
            }
            else
            {
                // Displays an error message
                MessageBox.Show($"Please enter data for all inputs");
            }
        }
    }
}
