using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _2200_AndersonK_Participation03
{
    /// <summary>
    /// Interaction logic for detailsWindow.xaml
    /// </summary>
    public partial class detailsWindow : Window
    {
        // Creates and initializes a public variable to store the information passed through for the sniff method
        public Plant selectedPlant { get; set; }
        public detailsWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Defines a method to update the labels that display the information of each plant
        /// </summary>
        /// <param name="plant"></param>
        public void setPlantDetails(Plant plant)
        {
            LblNameResults.Content = plant.name;
            LblEnvironmentResults.Content = plant.environment;
            LblTypeResults.Content = plant.type;
        }

        /// <summary>
        /// Defines the method and event handler for when the sniff button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSniff_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(selectedPlant.Sniff());
        }
    }
}
