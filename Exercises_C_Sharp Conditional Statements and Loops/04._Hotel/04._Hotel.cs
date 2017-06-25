using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthName = Console.ReadLine();
            var nightCount = int.Parse(Console.ReadLine());

            double studioPrice = 0.00;
            double @doublePrice = 0.00;
            double suitePrice = 0.00;

            double totalStudioPrice = 0.00;
            double totalDoublePrice = 0.00;
            double totalSuitePrice = 0.00;

            switch (monthName)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (nightCount > 7)
                    {
                        studioPrice = studioPrice * 0.95;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if (nightCount > 14)
                    {
                        doublePrice = doublePrice * 0.9;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nightCount > 14)
                    {
                        suitePrice *= 0.85;
                    }
                    break;
            }

            totalStudioPrice = studioPrice * nightCount;
            totalDoublePrice = doublePrice * nightCount;
            totalSuitePrice = suitePrice * nightCount;

            if ((monthName == "September" || monthName == "October") && nightCount > 7)
            {
                totalStudioPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:F2} lv.");

        }
    }
}
