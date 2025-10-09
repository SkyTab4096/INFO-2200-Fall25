/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: October 8, 2025
Participation or Assigment: 03
By submitting this assignment, I declare that the source code in this assignment was written solely by me, unless specified by the assignment.  I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicatly stated in the assignment instructions, nor from a subscription service.  I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will recieve a zero on this project if I am found in violation of this policy.
 */

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

namespace _2200_AndersonK_Assignment03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Initialize a new variable called animal to store the contents of the derived classes
        Animal animal;

        // Creates a new event handler method for when the skin type button is clicked
        private void Btn_SkinType_Click(object sender, RoutedEventArgs e)
        {
            // Update the contents of the results label with the contents of the animal skin type
            Lbl_Results.Content = animal.skinType;
        }

        // Create a new event handler method for when the food type button is clicked
        private void Btn_FoodType_Click(object sender, RoutedEventArgs e)
        {
            // Update the contents of the results label with the contents of the animal food type
            Lbl_Results.Content = animal.foodType;
        }

        // Create a new event handler method for when the eat button is clicked
        private void Btn_Eat_Click(object sender, RoutedEventArgs e)
        {
            // Update the contents of the results label with the value returned from the base animal class eat method
            Lbl_Results.Content = animal.eat();
        }

        // Create a new event handler for when the move button is clicked
        private void Btn_Move_Click(object sender, RoutedEventArgs e)
        {
            // Update the contents of the results label with the value returned from the derived class move method
            Lbl_Results.Content = animal.move();
        }

        // Create a new event handler for when the reproduce button is clicked
        private void Btn_Reproduce_Click(object sender, RoutedEventArgs e)
        {
            // Update the contents of the results label with the value returned from the base class reproduce method
            Lbl_Results.Content = animal.reproduce();
        }

        // Create a new event handler for when the unique button is clicked
        private void Btn_Unique_Click(object sender, RoutedEventArgs e)
        {
            // Update the contents of the results label with the value returned from the derived class unique method
            Lbl_Results.Content = animal.unique();
        }

        // Create a new event handler for when the dog radio button is selected
        private void Dog_Radio_Clicked(object sender, RoutedEventArgs e)
        {
            // Reclassify the animal variable as an object with the class of Dog then update the image to be the dog image
            animal = new Dog("","");
            Animal_Image.Source = new BitmapImage(new Uri("/Images/Dog.jpg", UriKind.Relative));
        }

        // Create a new event handler for when the cat radio button is selected
        private void Cat_Radio_Clicked(object sender, RoutedEventArgs e)
        {
            // Reclassify the animal variable as an object with the Cat class and then update the image to the cat image
            animal = new Cat("","");
            Animal_Image.Source = new BitmapImage(new Uri("/Images/Cat.jpg", UriKind.Relative));
        }

        // Create a new event handler for when the horse radio button is selected
        private void Horse_Radio_Clicked(object sender, RoutedEventArgs e)
        {
            // Reclassify the animal variable as a Horse object then update the image to the Horse image
            animal = new Horse("","");
            Animal_Image.Source = new BitmapImage(new Uri("/Images/Horse.jpg", UriKind.Relative));
        }
    }
}