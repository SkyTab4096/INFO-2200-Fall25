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

namespace _2200_AndersonK_Assignment02
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public DetailWindow()
        {
            InitializeComponent();
        }

        public void setNutritionalValues(Food food)
        {
            foodName.Content = food.foodName;
            foodType.Content = food.foodType;
            servingSize.Content = food.servingSize;
            weight.Content = food.weight.ToString();
            percentWater.Content = food.percentWater.ToString();
            calories.Content = food.energy.ToString();
            protein.Content = food.protein.ToString();
            carbohydrates.Content = food.carbohydrate.ToString();
            fiber.Content = food.fiber.ToString();
            cholesterol.Content = food.cholesterol.ToString();
            totalFat.Content = food.totalFat.ToString();
            saturateFat.Content = food.saturateFat.ToString();
            monosatFat.Content = food.monosatFat.ToString();
            polyunsatFat.Content = food.polyunsatFat.ToString();
            calcium.Content = food.calcium.ToString();
            iron.Content = food.iron.ToString();
            magnesium.Content = food.magnesium.ToString();
            sodium.Content = food.sodium.ToString();
            phosphorous.Content = food.phosphorous.ToString();
            capRatio.Content = food.capRation.ToString();
            potassium.Content = food.potassium.ToString();
            zinc.Content = food.zinc.ToString();
            niacian.Content = food.niacin.ToString();
            thiamin.Content = food.thiamin.ToString();
            riboflavin.Content = food.riboflavin.ToString();
            vitA.Content = food.vitA.ToString();
            vitB6.Content = food.vitB6.ToString();
            vitC.Content = food.vitC.ToString();
        }
    }
}
