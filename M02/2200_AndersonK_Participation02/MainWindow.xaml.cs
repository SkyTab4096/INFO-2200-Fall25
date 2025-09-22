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

namespace _2200_AndersonK_Participation02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Phone> phoneDict = new Dictionary<string, Phone>();
        public MainWindow()
        {
            InitializeComponent();
            LoadPhoneDetails();
        }

        /// <summary>
        /// Define a method to load the details for each phone into the program
        /// </summary>
        private void LoadPhoneDetails()
        {
            // Opens a stream reader to read the contents of the database file
            StreamReader inputFile;
            // Initializes a string array to store the details of each phone temporaraly
            string[] tempPhone;

            // Starts a error handling enviorment to read the contents of the file
            try
            {
                // Opens the database file
                inputFile = File.OpenText("phones.txt");
                // Starts a loop to read each line of the database file, and ends once the stream reader reachs the end of the file
                while (!inputFile.EndOfStream)
                {
                    // Loads the content of each line into a string array
                    tempPhone = inputFile.ReadLine().Split(',');
                    // Adds the model of the phone to the combo box for the user to select
                    cbPhones.Items.Add(tempPhone[1]);
                    // Adds the model of the phone to the dictionary as a key with all the details of the phone as a value
                    phoneDict.Add(tempPhone[1], new Phone(tempPhone));
                }
                // Closes the database file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // If the program ran into an error while reading the database file, display the contents of the error message
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Defines a new method to handle when the user clicks the display details button
        /// </summary>
        private void BtnPhoneDetails_Click(object sender, RoutedEventArgs e)
        {
            // Loads the details window into memory
            PhoneDetailsWindow pdw = new PhoneDetailsWindow();
            // Stores what phone model the user has selected once they click the show details button
            string key = cbPhones.SelectedItem.ToString();
            Phone phone;
            
            // Checks to make sure that the phone the user is one that has details
            if (phoneDict.TryGetValue(key, out phone))
            {
                // Calls the method to update the information on the details window
                pdw.UpdateGUI(phone);
                // Displays the phone details window
                pdw.Show();
            }
            else
            {
                // Displays an error message if the selected model was not in the database
                MessageBox.Show($"Could not find {key} in the database.");
            }
        }
    }
}