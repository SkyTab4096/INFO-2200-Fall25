using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_AndersonK_Assignment02
{
    public class Food
    {
        public Food(string[] foodArray)
        {
            foodName = foodArray[0];
            calcium = double.Parse(foodArray[1]);
            servingSize = foodArray[2];
            weight = double.Parse(foodArray[3]);
            percentWater = double.Parse(foodArray[4]);
            energy = double.Parse(foodArray[5]);
            protein = double.Parse(foodArray[6]);
            carbohydrate = double.Parse(foodArray[7]);
            fiber = double.Parse(foodArray[8]);
            cholesterol = double.Parse(foodArray[9]);
            totalFat = double.Parse(foodArray[10]);
            saturateFat = double.Parse(foodArray[11]);
            monosatFat = double.Parse(foodArray[12]);
            polyunsatFat = double.Parse(foodArray[13]);
            iron = double.Parse(foodArray[14]);
            magnesium = double.Parse(foodArray[15]);
            sodium = double.Parse(foodArray[16]);
            phosphorous = double.Parse(foodArray[17]);
            capRation = double.Parse(foodArray[18]);
            potassium = double.Parse(foodArray[19]);
            zinc = double.Parse(foodArray[20]);
            niacin = double.Parse(foodArray[21]);
            thiamin = double.Parse(foodArray[22]);
            riboflavin = double.Parse(foodArray[23]);
            vitA = double.Parse(foodArray[24]);
            vitB6 = double.Parse(foodArray[25]);
            vitC = double.Parse(foodArray[26]);
            foodType = foodArray[27];
        }
        public string foodName { get; set; }
        public double calcium { get; set; }
        public string servingSize { get; set; }
        public double weight { get; set; }
        public double percentWater { get; set; }
        public double energy { get; set; }
        public double protein { get; set; }
        public double carbohydrate { get; set; }
        public double fiber { get; set; }
        public double cholesterol { get; set; }
        public double totalFat { get; set; }
        public double saturateFat { get; set; }
        public double monosatFat { get; set; }
        public double polyunsatFat { get; set; }
        public double iron {  get; set; }
        public double magnesium { get; set; }
        public double sodium { get; set; }
        public double phosphorous { get; set; }
        public double capRation { get; set; }
        public double potassium { get; set; }
        public double zinc {  get; set; }
        public double niacin { get; set; }
        public double thiamin { get; set; }
        public double riboflavin { get; set; }
        public double vitA {  get; set; }
        public double vitB6 { get; set; }
        public double vitC { get; set; }
        public string foodType { get; set; }
    }
}
