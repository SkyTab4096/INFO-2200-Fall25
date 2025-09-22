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

namespace _2200_AndersonK_Participation02
{
    /// <summary>
    /// Interaction logic for PhoneDetailsWindow.xaml
    /// </summary>
    public partial class PhoneDetailsWindow : Window
    {
        public PhoneDetailsWindow()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Defines the method to update the information on the details window
        /// </summary>
        public void UpdateGUI(Phone phone)
        {
            // Updates the Display Size Label
            LblDisplay.Content = phone.DisplaySize;
            // Updates the Make of the phone
            LblMake.Content = phone.Make;
            // Updates the model of the phone
            LblModel.Content = phone.Model;
            // Updates the storage of the phone
            LblStorage.Content = phone.Storage;
            // Updates the price of the phone
            LblPrice.Content = phone.Price.ToString("c");

        }

        /// <summary>
        /// Defines a method to handle when the user clicks the button to close the window
        /// </summary>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
