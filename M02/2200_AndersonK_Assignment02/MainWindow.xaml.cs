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
        Dictionary<string, Food> foodDict = [];
        public MainWindow()
        {
            InitializeComponent();
            LoadNutritionInformation();
        }

        private void LoadNutritionInformation()
        {
            StreamReader inputFile;
            string[] tempFood;

            try
            {
                inputFile = File.OpenText("nutrition.txt");
                tempFood = inputFile.ReadLine().Split('\t');
                while (!inputFile.EndOfStream)
                {
                    tempFood = inputFile.ReadLine().Split("\t");
                    cbFoods.Items.Add(tempFood[0]);
                    foodDict.Add(tempFood[0], new Food(tempFood));
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbFoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DetailWindow dw = new();

            string key = cbFoods.SelectedItem.ToString();

            if (foodDict.TryGetValue(key, out Food food))
            {
                dw.setNutritionalValues(food);
                dw.Show();
            }
            else
            {
                MessageBox.Show($"Food {key} not found in database");
            }
        }
    }
}