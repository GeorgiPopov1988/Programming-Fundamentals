namespace Problem_1___Hornet_Wings
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
            long wingFlaps = long.Parse(Console.ReadLine());
            double distanceForThousandFlaps = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            int flapsPerSec = 100;
            int oneRestTime = 5;

            double distance = (wingFlaps / 1000) * distanceForThousandFlaps;
            double flapsTime = wingFlaps / flapsPerSec;
            double restTime = (wingFlaps / endurance) * oneRestTime;
            double allTime = restTime + flapsTime;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{allTime} s.");


        }
    }
}
