namespace _01_Letter_Repetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = new Dictionary<char, int>();

            foreach (char currentChar in input)
            {
                if (!result.ContainsKey(currentChar))
                {
                    result[currentChar] = 0;
                }

                result[currentChar]++;

            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
