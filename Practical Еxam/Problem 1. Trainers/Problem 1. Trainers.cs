namespace Problem_1.Trainers
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
            Dictionary<string, List<decimal>> result = new Dictionary<string, List<decimal>>();

            decimal cargoPricePerKilogram = 1.5m;
            decimal fuelPricePerLiter = 2.5m;
            decimal trainConsumPerMeter = 0.7m;

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int distanceInMiles = int.Parse(Console.ReadLine()); // in miles
                decimal cargoInTons = decimal.Parse(Console.ReadLine()); // in tons
                string participant = Console.ReadLine();



                // Conversion of units

                int distanceInMeters = distanceInMiles * 1600;
                decimal cargoInKillograms = cargoInTons * 1000;

                // Calculate result

                decimal participantEarnedMoney =
                    (cargoInKillograms * cargoPricePerKilogram)
                    - (trainConsumPerMeter * distanceInMeters * fuelPricePerLiter);

                if (!result.ContainsKey(participant))
                {
                    result.Add(participant, new List<decimal>());
                }
                result[participant].Add(participantEarnedMoney);
            }


            //result = result
            //    .Where(k => k.Value >= 0)
            //    .OrderByDescending(m => m.Value)
            //    .ToDictionary(k => k.Key, v => v.Value);
            decimal max = 0;
            string best = string.Empty;

            foreach (var team in result)
            {
                

                if (team.Value.Max() > max)
                {
                    max = team.Value.Max();
                    best = team.Key;
                }
                //Console.WriteLine($"{team.Key} - {string.Join(", ",team.Value)}");
                
               
            }

            Console.WriteLine($"The {best} Trainers win with ${max:F3}.");

        }
    }
}
