namespace _05_Flatten_Dictionary
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
            var data = new Dictionary<string, Dictionary<string, string>>();
            var flattanedData = new Dictionary<string, List<string>>();

            string userInput = Console.ReadLine();

            while (userInput != "end")
            {
                string[] inputTokens = userInput.Split(' ');

                if (inputTokens[0] == "flatten")
                {
                    FlattingData(data, flattanedData, inputTokens);

                }
                else
                {
                    AddigCurrentData(data, inputTokens);
                }

                userInput = Console.ReadLine();
            }

            Printing(data, flattanedData);
        }

        private static void Printing(Dictionary<string, Dictionary<string, string>> data, Dictionary<string, List<string>> flattanedData)
        {
            var orderedData = data.OrderByDescending(kvp => kvp.Key.Length);

            foreach (var record in orderedData)
            {
                string key = record.Key;
                var innerRecords = record.Value;

                var orderedInnerRecords = innerRecords.OrderBy(kvp => kvp.Key.Length);

                Console.WriteLine($"{key}");

                int index = 1;

                foreach (var innerRecord in orderedInnerRecords)
                {

                    Console.WriteLine($"{index}. {innerRecord.Key} - {innerRecord.Value}");
                    index++;
                }

                if (flattanedData.ContainsKey(key))
                {
                    foreach (var flattanedValue in flattanedData[key])
                    {
                        Console.WriteLine($"{index}. {flattanedValue}");
                        index++;
                    }
                }
            }
        }

        private static void AddigCurrentData(Dictionary<string, Dictionary<string, string>> data, string[] inputTokens)
        {
            string key = inputTokens[0];
            string innerKey = inputTokens[1];
            string innerValue = inputTokens[2];

            if (!data.ContainsKey(key))
            {
                data.Add(key, new Dictionary<string, string>());
            }
            if (!data[key].ContainsKey(innerKey))
            {
                data[key].Add(innerKey, "");
            }
            data[key][innerKey] = innerValue;
        }

        private static void FlattingData(Dictionary<string, Dictionary<string, string>> data, Dictionary<string, List<string>> flattanedData, string[] inputTokens)
        {
            string keyToFlatten = inputTokens[1];

            foreach (var record in data)
            {
                string key = record.Key;
                var innerRecords = record.Value;

                if (key == keyToFlatten)
                {

                    foreach (var innerRecord in innerRecords)
                    {
                        string flattanedValue = innerRecord.Key + innerRecord.Value;

                        if (!flattanedData.ContainsKey(key))
                        {
                            flattanedData.Add(key, new List<string>());
                        }
                        flattanedData[key].Add(flattanedValue);
                    }
                }
            }

            data[keyToFlatten] = new Dictionary<string, string>();
        }
    }
}
