using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfIngredients = int.Parse(Console.ReadLine());

            var cheeseCalories = 500;
            var tomatoSauceCalories = 150;
            var salamiCalories = 600;
            var pepperCalories = 50;

            var totalCaloriesCounter = 0;

            for (int i = 0; i < numOfIngredients; i++)
            {
                var productImput = Console.ReadLine().ToLower();

                switch (productImput)
                {
                    case "cheese":
                        totalCaloriesCounter += cheeseCalories;
                        break;
                    case "tomato sauce":
                        totalCaloriesCounter += tomatoSauceCalories;
                        break;
                    case "salami":
                        totalCaloriesCounter += salamiCalories;
                        break;
                    case "pepper":
                        totalCaloriesCounter += pepperCalories;
                        break;
                    default:
                        continue;
                }


            }

            Console.WriteLine($"Total calories: {totalCaloriesCounter}");


        }
    }
}
