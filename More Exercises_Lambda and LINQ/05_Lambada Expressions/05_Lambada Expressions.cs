namespace _05_Lambada_Expressions
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
            string input = Console.ReadLine();

            var result = new Dictionary<string, string>();

            while (input != "lambada")
            {
                string[] tokens = input
                    .Split(" =>".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input != "dance")
                {

                    string key = tokens[0];
                    string value = tokens[1];

                    if (!result.ContainsKey(key))
                    {
                        result[key] = string.Empty;
                    }
                    result[key] = value;
                }

                else
                {
                    result = result
                        .ToDictionary(k => k.Key, k => k.Key + "." + k.Value);
                }

                input = Console.ReadLine();
            }
            foreach (var item in result)
            {
                var key = item.Key;
                var value = item.Value;

                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}
