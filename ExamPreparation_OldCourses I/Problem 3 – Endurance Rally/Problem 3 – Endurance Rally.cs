namespace Problem_3___Endurance_Rally
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] drivers = Console.ReadLine()
                .Split( ' ' );
            double[] zones = Console.ReadLine()
                .Split( ' ' )
                .Select(double.Parse)
                .ToArray();
            int[] indexToAdd = Console.ReadLine()
                .Split( ' ' )
                .Select(int.Parse)
                .ToArray();

            foreach (var driver in drivers)
            {
                double fuel = driver.First();

                for (int index = 0; index < zones.Length; index++)
                {
                    double currentZone = zones[index];

                    if (indexToAdd.Contains(index))
                    {
                        fuel += currentZone; //add fuel
                    }
                    else
                    {
                        fuel -= currentZone; //remove fuel

                        if (fuel <= 0)
                        {
                            Console.WriteLine($"{driver} - reached {index}");
                            break;
                        }
                    }

                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
                
            }

        }
    }
}
