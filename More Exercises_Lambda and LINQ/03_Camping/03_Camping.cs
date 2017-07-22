namespace _03_Camping
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
            string userInput = Console.ReadLine();

            var allDaysToStay = new Dictionary<string, int>();
            var campersTypes = new Dictionary<string, List<string>>();

            while (userInput != "end")
            {
                string[] input = userInput
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                string camperModel = input[1];
                int timeToStay = int.Parse(input[2]);

                if (!allDaysToStay.ContainsKey(name) && !campersTypes.ContainsKey(name))
                {
                    allDaysToStay[name] = 0;
                    campersTypes[name] = new List<string>();
                }

                allDaysToStay[name] += timeToStay;
                campersTypes[name].Add(camperModel);

                userInput = Console.ReadLine();
            }

            campersTypes = campersTypes
                .OrderBy(k => k.Key.Length)
                .OrderByDescending(v => v.Value.Count)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var person in campersTypes)
            {
                string name = person.Key;
                List<string> types = person.Value;

                Console.WriteLine($"{name}: {person.Value.Count}");

                foreach (var type in types)
                {
                    Console.WriteLine($"***{type}");
                }

                Console.WriteLine($"Total stay: {allDaysToStay[name]} nights");

            }
        }
    }
}
