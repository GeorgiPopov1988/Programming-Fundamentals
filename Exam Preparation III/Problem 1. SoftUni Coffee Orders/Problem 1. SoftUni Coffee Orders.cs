namespace Problem_1.SoftUni_Coffee_Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            long countOfOrders = long.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            decimal price = 0;
            decimal[] allPrices = new decimal[countOfOrders];

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string inputDate = Console.ReadLine();
                DateTime date = DateTime.ParseExact
                                (inputDate, "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal month = date.Month;
                decimal year = date.Year;
                decimal daysInMonth = DateTime.DaysInMonth((int)year, (int)month);
                long capsulesCnt = long.Parse(Console.ReadLine());

                price = (daysInMonth * capsulesCnt) * pricePerCapsule;
                allPrices[i] = price;
                totalPrice += price;
               
                
            }

            foreach (var currentPrice in allPrices)
            {
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }
                Console.WriteLine($"Total: ${totalPrice:F2}");
            
        }
    }
}
