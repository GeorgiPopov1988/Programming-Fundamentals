using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var packageType = Console.ReadLine();

            var hallName = string.Empty;
            var hallPrice = 0;
            var discountPercent = 0;
            var servicePrice = 0;


            if (groupSize <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (packageType)
            {
                case "Normal":
                    discountPercent = 5;
                    servicePrice = 500;
                    break;
                case "Gold":
                    discountPercent = 10;
                    servicePrice = 750;
                    break;
                case "Platinum":
                    discountPercent = 15;
                    servicePrice = 1000;
                    break;
            }

            double totalPrice = hallPrice + servicePrice;
            double discountTotal = (totalPrice / 100) * discountPercent;
            double pricePerPerson = (totalPrice - discountTotal) / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");


        }
    }
}