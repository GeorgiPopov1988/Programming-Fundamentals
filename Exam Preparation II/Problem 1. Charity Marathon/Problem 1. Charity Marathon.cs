namespace Problem_1.Charity_Marathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            long marathonDays = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            long startRunners;
            double money;

            long maximumRunners = trackCapacity * marathonDays;

            if (maximumRunners >= runners)
            {
                startRunners = runners;
            }
            else
            {
                startRunners = maximumRunners;
            }

            long totalMeters = startRunners * laps * trackLength;
            long totalKilometers = totalMeters / 1000;

            money = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {money:F2}");


        }
    }
}
