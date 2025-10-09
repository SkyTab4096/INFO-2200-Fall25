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

namespace _2200_AndersonK_Participation03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Creates a dictionary to store the information for each plant with a key of the plant name
        Dictionary<string, Plant> plantDict = new Dictionary<string, Plant>();
        public MainWindow()
        {
            InitializeComponent();
            loadPlants();
        }

        /// <summary>
        /// Defines a method to load the different options into the combo boxes for creating new plants
        /// </summary>
        private void loadPlants()
        {
            // Adds the options to the Environment combo box
            CbEnvironment.Items.Add("Forest");
            CbEnvironment.Items.Add("Desert");
            CbEnvironment.Items.Add("Tropical");
             
            // Adds the options to the type combo box
            CbType.Items.Add("Flower");
            CbType.Items.Add("Tree");
            CbType.Items.Add("Shrub");
        }

        /// <summary>
        /// Defines a method to make sure that the values the user entered are valid for a plant
        /// </summary>
        /// <returns></returns>
        public bool validInput()
        {
            // Runs the actual checks on the values that the user entered, and if there was any errors stores what they were into an error message variable
            string errMessage = "";
            if (TxtBoxName.Text == "") errMessage += "Please enter a name for the plant.\n\n";
            if (CbEnvironment.SelectedIndex == -1) errMessage += "Please select an environment.\n\n";
            if (CbType.SelectedIndex == -1) errMessage += "Please select a plant type.\n\n";

            // Checks to see if there are any stored error messages
            if (errMessage == "") return true; else
            {
                // Displays any error messages
                MessageBox.Show(errMessage, "Invalid Input");
                return false;
            }

        }

        /// <summary>
        /// Defines a method and event handler for when the user clicks the Add Plant button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            // Checks to make sure the user entered valid information
            if (validInput())
            {
                // Creates a temporary variable of the plant class
                Plant plant = null;
                // Checks to see which plant type the user has selected
                switch (CbType.SelectedItem)
                {
                    // If the type selected is a tree create a new plant with the class of tree
                    case "Tree":
                        plant = new Tree(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);
                        break;
                    // If the type selected is a flower create a new plant with the class of flower
                    case "Flower":
                        plant = new Flower(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);
                        break;
                    // If the type selected is a shrub create a new plant with the class of shrub
                    case "Shrub":
                        plant = new Shrub(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);
                        break;
                    // If somehow the type selected is not one of the only typs in the combo box, show an error message
                    default:
                        MessageBox.Show("I have no idea how we got here.");
                        break;
                }
                // Check to make sure a plant was created
                if (plant != null)
                {
                    // Add the newly created plant to the list box of plants
                    LstBoxPlants.Items.Add(plant.name);
                    // Add the newly created plant to the plant dictionary
                    plantDict.Add(plant.name, plant);
                }
            }
        }

        /// <summary>
        /// Defines a method and event handler for when the user clicks the show details button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
        {
            // Checks to make sure a plant was selected
            if (LstBoxPlants.SelectedIndex > -1)
            {
                // Creates a new instance of the detail window
                detailsWindow dw = new detailsWindow();
                // Gets the value of what the user selected
                string key = LstBoxPlants.SelectedItem.ToString();

                // Attempts to see if the value the user selected is in the plant dictionary, should always
                if (plantDict.TryGetValue(key, out Plant plant))
                {
                    // Calls the method on the details window to update the content of the results labels
                    dw.setPlantDetails(plant);
                    // Defines the passed through variable on the details window
                    dw.selectedPlant = plant;
                    // Displays the updated details window
                    dw.Show();
                }
                else
                {
                    // Show an error message if somehow the value the user selected is not in the database
                    MessageBox.Show("Could not find that plant in the database");
                }
            }
        }

        /// <summary>
        /// Defines a method and event handler for when the user selects a different plant type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Checks to see which plant type the user selected
            switch (CbType.SelectedItem)
            {
                // If the type the user selected is a tree, update the plant type image to the image of a tree
                case "Tree":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/tree.jpg", UriKind.Relative));
                    break;
                // If the type the user selected is a flower, update the plant type image to the image of a flower
                case "Flower":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/rose.png", UriKind.Relative));
                    break;
                // If the type the user selected is a shrub, update the plant type image to the image of a shrub
                case "Shrub":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/shrub.png", UriKind.Relative));
                    break;
                // If somehow the user selected a type that doesn't exist, do nothing
                default: break;
            }
        }

        /// <summary>
        /// Defines a method and event handler for when the user selects a different environment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbEnvironment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Checks to see which environment the user selected
            switch (CbEnvironment.SelectedItem)
            {
                // If the user selected a forest environment, update the environment image to the forest image
                case "Forest":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/forest.png", UriKind.Relative));
                    break;
                // If the user selected a desert environment, update the evnironment image to the desert image
                case "Desert":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/desert.png", UriKind.Relative));
                    break;
                // If the user selected a tropical environment, update the environment image to the tropical image
                case "Tropical":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/tropical.jpg", UriKind.Relative));
                    break;
                // If somehow the user selected an environment that doesn't exist, do nothing
                default: break;
            }
        }
    }
}