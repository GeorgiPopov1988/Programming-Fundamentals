namespace _04_Shellbound
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

            var result = new Dictionary<string, HashSet<int>>();
            

            while (input != "Aggregate")
            {
                string[] userInput = input.Split(' ');

                string region = userInput[0];
                int shell = int.Parse(userInput[1]);

                if (!result.ContainsKey(region))
                {
                    result[region] = new HashSet<int>();
                }
                result[region].Add(shell);

                input = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                int giantShell = kvp.Value.Sum() - (int)kvp.Value.Average();

                Console.WriteLine($"{kvp.Key} -> {string.Join(", ", kvp.Value)} ({giantShell})");
            }
            
        }
    }
}
