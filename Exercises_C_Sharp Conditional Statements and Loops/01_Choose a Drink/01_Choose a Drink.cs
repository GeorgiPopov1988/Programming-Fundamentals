using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Choose_a_Drink
{
    class Choose_a_Drink
    {
        static void Main(string[] args)
        {

            var profession = Console.ReadLine();
            var perfectDrink = string.Empty;

            switch (profession)
            {
                case "Athlete":
                    perfectDrink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    perfectDrink = "Coffee";
                    break;
                case "SoftUni Student":
                    perfectDrink = "Beer";
                    break;
                default:
                    perfectDrink = "Tea";
                    break;

            }

            Console.WriteLine(perfectDrink);
        }
    }
}
