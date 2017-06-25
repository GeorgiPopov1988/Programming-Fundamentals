using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_Beverage_Labels
{
    class Problem4_Beverage_Labels
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContentPer100ml = double.Parse(Console.ReadLine());
            double sugarContentPer100ml = double.Parse(Console.ReadLine());

            double index = volume / 100;

            double energyContent = energyContentPer100ml * index;
            double sugraContent = sugarContentPer100ml * index;

            Console.WriteLine($"{volume}ml {productName}:\n" +
                              $"{energyContent}kcal, {sugraContent}g sugars");


        }
    }
}
