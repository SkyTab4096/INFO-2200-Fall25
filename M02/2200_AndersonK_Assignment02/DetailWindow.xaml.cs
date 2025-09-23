/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: September 23, 2025
Participation or Assignment #: 02
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/

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

        /// <summary>
        /// Defines the method to update the information in the labels on the details window
        /// </summary>
        /// <param name="food"></param>
        public void setNutritionalValues(Food food)
        {
            // Runs through each label that needs to have it's content updated and redefines what the content of the label is
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
