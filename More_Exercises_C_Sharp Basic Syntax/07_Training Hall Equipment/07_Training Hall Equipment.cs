using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int itemsCnt = int.Parse(Console.ReadLine());

            double currentTotalPrice = 0;

            for (int cnt = 0; cnt < itemsCnt; cnt++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());

                if (quantity > 1)
                {
                    itemName += 's';
                }

                Console.WriteLine($"Adding {quantity} {itemName} to cart.");
                currentTotalPrice += quantity * itemPrice;
            }
            Console.WriteLine($"Subtotal: ${currentTotalPrice:F2}");

            double budgetLeft = budget - currentTotalPrice;

            if (budgetLeft > 0)
            {
                Console.WriteLine($"Money left: ${budgetLeft:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budgetLeft):F2} more.");
            }

            Console.WriteLine();
        }
    }
}
