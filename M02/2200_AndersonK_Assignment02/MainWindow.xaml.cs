/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: September 23, 2025
Participation or Assignment #: 02
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/

using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2200_AndersonK_Assignment02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Creates a new dictionary to store the food information with the food name as the key
        Dictionary<string, Food> foodDict = [];
        public MainWindow()
        {
            InitializeComponent();
            // Calls the method to read the information from the database file
            LoadNutritionInformation();
        }

        /// <summary>
        /// Defines the method to read the database file
        /// </summary>
        private void LoadNutritionInformation()
        {
            // Creates a stream reader to actually read the contents of the databse file
            StreamReader inputFile;
            // Initializes an array of strings to be used to temporary store information from the database
            string[] tempFood;

            // Starts an enviorment with built in error handling
            try
            {
                // Gives the file to be read to the stream reader and starts reading the contents
                inputFile = File.OpenText("nutrition.txt");
                // Reads anc voids the first line of the database file
                tempFood = inputFile.ReadLine().Split('\t');
                // Starts a loop to read every line of the file until it reaches the end of the file
                while (!inputFile.EndOfStream)
                {
                    // Temporarilly stores the contents of a line in the database file into the string arry initialized earlier
                    tempFood = inputFile.ReadLine().Split("\t");
                    // Adds the food name to the combo box so the user can select a food
                    cbFoods.Items.Add(tempFood[0]);
                    // Adds the food tho the food dictionary with the food name as the key and the whole set of information as the value
                    foodDict.Add(tempFood[0], new Food(tempFood));
                }
                // Closes the file
                inputFile.Close();
            }
            // Moves to the error handling portion of the enviorment
            catch (Exception ex)
            {
                // Display what error was encountered
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Defines a method to call the detail window once the user selects a new food
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Calls the detail window
            DetailWindow dw = new();

            // Stores what food the user has selected
            string key = cbFoods.SelectedItem.ToString();

            // Attempts to find the food that the user selected in the dictionary
            if (foodDict.TryGetValue(key, out Food food))
            {
                // If the selected food was found, calls the method to update the displayed information on the detail window
                dw.setNutritionalValues(food);
                // Actually displays the detail window
                dw.Show();
            }
            else
            {
                // If the food was not found in the dictionary display an error message.
                MessageBox.Show($"Food {key} not found in database");
            }
        }
    }
}