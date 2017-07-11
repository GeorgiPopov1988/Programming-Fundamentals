using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Group_Continents_and_Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] currentInput = Console.ReadLine().Split(' ');
                string continent = currentInput[0];
                string country = currentInput[1];
                string city = currentInput[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent,
                        new SortedDictionary<string, SortedSet<string>>());
                }
                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new SortedSet<string>());
                }
                continentsData[continent][country].Add(city);
            }

            foreach (var item in continentsData)
            {
                string continent = item.Key;
                var currentCountry = item.Value;

                Console.WriteLine($"{continent}:");

                foreach (var data in currentCountry)
                {
                    string country = data.Key;
                    SortedSet<string> city = data.Value;
                    Console.WriteLine($"{country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
