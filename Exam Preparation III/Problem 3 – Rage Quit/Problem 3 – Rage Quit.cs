namespace Problem_3___Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            string rgx = @"(\D+)(\d+)";
            Regex regex = new Regex(rgx);

            MatchCollection collection = regex.Matches(input);
            StringBuilder result = new StringBuilder();
            int count = 0;

            foreach (Match match in collection)
            {
                count = int.Parse(match.Groups[2].ToString());
                for (int i = 0; i < count; i++)
                {
                    result.Append(match.Groups[1]);
                }
            }
            count = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine($"{result}");

        }
    }
}
