namespace _03_Travel_Company
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
            var result = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split(':');

            while (input[0] != "ready")
            {

                string town = input[0];

                string[] transportAndCapacity = input[1].Split(new char[] { '-', ',' });

                for (int i = 0; i < transportAndCapacity.Length; i += 2)
                {
                    string typeTransport = transportAndCapacity[i];
                    int capacity = int.Parse(transportAndCapacity[i + 1]);
                    
                    if (!result.ContainsKey(town))
                    {
                        result.Add(town, new Dictionary<string, int>());
                        result[town].Add(typeTransport, capacity);
                    }
                    else if (!result[town].ContainsKey(typeTransport))
                    {
                        result[town].Add(typeTransport, capacity);
                    }
                    else
                    {
                        result[town][typeTransport] = capacity;
                    }

                }

                input = Console.ReadLine().Split(':');
            }

            string entryInfo = Console.ReadLine();

            List<string> destination = new List<string>();
            List<int> groupCount = new List<int>();

            while (entryInfo != "travel time!")
            {
                string[] travelingDestinations = entryInfo.Split(' ').ToArray();

                string destinationTown = travelingDestinations[0];
                int totalgroupnumbers = int.Parse(travelingDestinations[1]);

                destination.Add(destinationTown);
                groupCount.Add(totalgroupnumbers);

                entryInfo = Console.ReadLine();
            }

            for (int k = 0; k < destination.Count; k++)
            {
                if (result.ContainsKey(destination[k]))
                {
                    Dictionary<string, int> acomodations = result[destination[k]];

                    string town = destination[k];
                    int grouptotal = groupCount[k];
                    int totalplaces = 0;

                    foreach (int num in acomodations.Values)
                    {
                        totalplaces += num;
                    }
                    if (totalplaces - grouptotal >= 0)
                    {
                        Console.WriteLine($"{town} -> all {grouptotal} accommodated");
                    }
                    else
                    {
                        Console.WriteLine("{0} -> all except {1} accommodated", town, Math.Abs(totalplaces - grouptotal));
                    }
                }
            }
        }
    }
}
