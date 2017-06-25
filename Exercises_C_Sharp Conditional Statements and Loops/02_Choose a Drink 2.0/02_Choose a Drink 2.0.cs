using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var waterPrice = 0.70;
            var coffeePrice = 1.00;
            var beerPrice = 1.70;
            var teaPrice = 1.20;

            var totalPrice = 0.0;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = waterPrice * quantity;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = coffeePrice * quantity;
                    break;
                case "SoftUni Student":
                    totalPrice = beerPrice * quantity;
                    break;
                default:
                    totalPrice = teaPrice * quantity;
                    break;

            }
            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");


        }
    }
}
