namespace _02_KeyKeyValueValu
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
            string inputKey = Console.ReadLine();
            string inputValue = Console.ReadLine();

            var result = new Dictionary<string, List<string>>();

            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                string currentKey = input[0];
                List<string> currentValues = input[1].Split(';').ToList();

                if (!result.ContainsKey(currentKey))
                {
                    result[currentKey] = new List<string>();
                }
                result[currentKey] = currentValues;


               
            }

            foreach (var item in result)
            {
                bool containsInKey = item.Key.Contains(inputKey);

                if (containsInKey)
                {
                    Console.WriteLine($"{item.Key}:");

                    foreach (var val in item.Value)
                    {
                        bool containsInValue = val.Contains(inputValue);

                        if (containsInValue)
                        {
                            Console.WriteLine($"-{val}");
                        }

                    }

                }

            }
        }
    }
}
